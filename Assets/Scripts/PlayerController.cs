using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Install the package, then include this namespace for Gyro
// For WebGL on iOS, go to Project Settings > Input System Package
// Enable Motion Usage
// Make sure to create a settings asset when prompted.
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float friction;
	public Text scoreText;
	public Text healthText;
	public GameObject endGameContainer;
	private int score = 0;
	private int health = 5;
	private Rigidbody rb;
	// This function pointer will allow us to conditionally determine how to move,
	// Based on input devices available on the current playform. Bitchin'.
	public delegate void InputFuncPtr();
	InputFuncPtr movefunction = null;

	void Start()
	{
		// https://docs.unity3d.com/ScriptReference/RuntimePlatform.html
		// Checks for accelerometer support, or an editor being used. Remove the other two options to get your input back.
		if (SystemInfo.supportsAccelerometer == true)
		{
			// Any sensors used must be manually enabled
			InputSystem.EnableDevice(Accelerometer.current);
			movefunction = new InputFuncPtr(moveMobile);
		}
		else
			movefunction = new InputFuncPtr(moveKbd);
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
	    if (Input.GetButtonDown("Cancel"))
		    StartCoroutine(LoadSceneWait(0.0f, "menu"));
		movefunction();
	}

	void moveKbd()
	{
		Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		if (direction != Vector3.zero)
			rb.AddForce(direction * speed);
		else
			rb.velocity *= Mathf.Clamp01(1f - friction * Time.fixedDeltaTime);
	}

	void moveMobile()
	{
		Vector3 tilt, force;
		float currentTiltMagnitude, tiltAcceleration;
		float previousTiltMagnitude = 0, deadzone = 0.08f, zOffset = 0.707f;
		// Read and adjust the device angle
		tilt = Accelerometer.current.acceleration.ReadValue();
		tilt = Quaternion.Euler(90, 0, 0) * tilt; // Rotate the tilt vector to match the game's orientation
		// tilt.Normalize(); Might do something if tilt = tilt.Normalize? Seems like a dumb idea if it did work,
		// Normalize floors to 1 or 0.


		// Track movement between frames
		currentTiltMagnitude = tilt.magnitude;
		tiltAcceleration = (currentTiltMagnitude - previousTiltMagnitude) / Time.deltaTime;
		previousTiltMagnitude = currentTiltMagnitude;

		// Apply the tilt vector as a force in the X and Z directions, while keeping the player grounded in the Y direction
		// zOffset represents the sine of 45 degrees; this way, you can hold your phone at an angle and move instead of vertically
		// Try it!
		// zOffset = 0;
		force = new Vector3(tilt.x, 0, tilt.y - zOffset);

		// This detects if input is in the deadzone; Else represents no player input
		if (force.magnitude > deadzone)
		{
			float speedModFactor = 2.5f;
			float currentSpeed = speed + tiltAcceleration * speedModFactor;
			rb.AddForce(force * currentSpeed);
			rb.velocity = Vector3.ClampMagnitude(rb.velocity, 10f);
		}
		else
			rb.velocity *= Mathf.Clamp01(1f - friction * Time.fixedDeltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		contactMan(other);
	}

	void UpdateTextObj(Component textObject, string newValue)
	{
		// Checks type and value, only possible to enter this code if
		// A text component exists!
		if (textObject is Text isText)
			isText.text = newValue;
		else
            Debug.Log("Not a text object!");
    }

	void contactMan(Collider other)
	{
		// Increment score when Player touches object with Pickup tag
		// Destroy Pickup on contact
		if (other.gameObject.CompareTag("Pickup"))
		{

			Destroy(other.gameObject);
			UpdateTextObj(scoreText, "Score: " + ++score);
			if (score == 40)
			{
				Debug.Log("All Coins Collected!");
				score = 0;
			}
		}
		else if (other.gameObject.CompareTag("Trap"))
		{

			UpdateTextObj(healthText, "Health: " + --health);
			if (health == 0)
			{
				EndGameUI("Lose");
				StartCoroutine(LoadSceneWait(3));
			}
		}
		else if (other.gameObject.CompareTag("Goal"))
			EndGameUI("Win");
	}

	IEnumerator LoadSceneWait (float time = 0.0f, string sceneName = null)
	{
		yield return new WaitForSeconds(time);
		if (sceneName == null)
			sceneName = SceneManager.GetActiveScene().name;
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

		// Refuse to yield control to the caller until loading is finished
		while (!asyncLoad.isDone)
			yield return null;
	}

	void EndGameUI(string EndState)
	{
		// https://docs.unity3d.com/ScriptReference/Color-ctor.html
		string endStateText;
		Color textColor, containerColor;
		if (EndState.Equals("Win"))
		{
			endStateText = "You Win!";
			textColor = Color.black;
			containerColor = Color.green;
		}
		else
		{
			endStateText = "Game Over!";
			textColor = Color.white;
			containerColor = Color.red;
		}

		// Start from the top and work down the hierarchy.
		Image endGamePrompt = endGameContainer.GetComponent<Image>();
		Text endGameText = endGamePrompt.GetComponentInChildren<Text>();
		// Update fields from bottom to top
		UpdateTextObj(endGameText, endStateText);
		endGameText.color = textColor;
		endGamePrompt.color = containerColor;
		// Fire!
		// https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
		endGameContainer.SetActive(true);
	}
}
