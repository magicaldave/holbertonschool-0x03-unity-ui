using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	    public float speed = 3.0f;
	    public float friction = 17.5f;
	    public Text scoreText;
	    public Text healthText;
	    public GameObject endGameContainer;
	    // This vector is used to store the player's actual velocity
	    private Vector3 velocity = Vector3.zero;
	    private int score = 0;
	    private int health = 5;

	    void Start()
	    {
		    // https://docs.unity3d.com/ScriptReference/RuntimePlatform.html
		    if (Application.platform != RuntimePlatform.WebGLPlayer)
			    Debug.Log("Hey! You're not using a WebGL build. You should use the Remote to get sensor input.");
		    else
		    {
			    Debug.Log("We'll write some code here later to instantiate the Sensor class.");
		    }
	    }

	    // Update is called once per frame
	    void Update()
	    {
		    // These should be Either 1 or -1. They're floats to support controller or gyro input.
		    // This is how I check if you're actually moving.
		    // The transform information is duplicated, with positive or negative values of 1 representing the translation direction
		    // When magnitude is greater than zero, you pressed a button.
		    Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));


		    if (direction.magnitude > 0)
		    {
			    // Direction * Speed * Time since last fram (Seconds)
			    velocity += direction * speed * Time.deltaTime;
			    // Speed limit!
			    velocity = Vector3.ClampMagnitude(velocity, 20.0f);
		    }
		    else
		    {
			    // Deceleration is still ongoing.
			    velocity = velocity.normalized * friction * Time.deltaTime;
			    if (velocity.magnitude < 0.1f)
			    {
				    velocity = Vector3.zero;
			    }
		    }
		    transform.position += velocity * Time.deltaTime;

		    // Debug.Log("Accelerometer input: " + Input.acceleration);
		    transform.position += new Vector3(Input.acceleration.x, 0, 0);

    }
	    void OnTriggerEnter(Collider other)
	    {
		    // Increment score when Player touches object with Pickup tag
		    // Destroy Pickup on contact
		    if (other.gameObject.CompareTag("Pickup"))
		    {
			    Destroy(other.gameObject);
			    UpdateTextObj(scoreText, "Score: " + ++score);
		    }
		    else if (other.gameObject.CompareTag("Trap"))
		    {
			    UpdateTextObj(healthText, "Health: " + --health);
		    }
		    else if (other.gameObject.CompareTag("Goal"))
		    {
			    EndGameUI("win");
		    }
		    ResetMan();
	    }

	    void ResetMan()
	    {
		    if (score == 40)
		    {
			    Debug.Log("All Coins Collected!");
			    score = 0;
		    }
		    else if (health == 0)
		    {
			    health = score = 0;
			    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
		    }
	    }

	    void UpdateTextObj(Component TextObj, string Value)
	    {
		    Text UpdateObj = TextObj.GetComponent<Text>();
		    if (UpdateObj != null)
		    {
			    UpdateObj.text = Value;
		    }
	    }

	    void EndGameUI(string EndState)
	    {
	    // https://docs.unity3d.com/ScriptReference/Color-ctor.html
		    string EndStateText;
		    Color TextColor, ContainerColor;
		    if (EndState.Equals("win"))
		    {
			    EndStateText = "You Win!";
			    TextColor = new Color(0, 0, 0, 1);
			    ContainerColor = new Color(0, 1, 0, 1);

		    }
		    else
		    {
			    EndStateText = "You Lose!";
			    TextColor = new Color(0, 0, 0, 1);
			    ContainerColor = new Color(0, 1, 0, 1);
		    }

		    // Start from the top and work down the hierarchy.
		    Image endGamePrompt = endGameContainer.GetComponent<Image>();
		    Text endGameText = endGamePrompt.GetComponentInChildren<Text>();
		    // Update fields from bottom to top
		    UpdateTextObj(endGameText, EndStateText);
		    endGameText.color = TextColor;
		    endGamePrompt.color = ContainerColor;
		    // Fire!
		    // https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
		    endGameContainer.SetActive(true);
	    }
}
