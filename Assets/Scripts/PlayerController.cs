using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	    public float speed = 3.0f;
	    public float friction = 17.5f;
	    public Text scoreText;
	    // This vector is used to store the player's actual velocity
	    private Vector3 velocity = Vector3.zero;
	    private int score = 0;
	    private int health = 5;

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

		    if (score == 40)
		    {
			    Debug.Log("All Coins Collected!");
			    score = 0;
		    }
		    if (health == 0)
		    {
			    Debug.Log("Game Over!");
			    health = score = 0;
			    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
		    }
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
			    ++score;
			    SetScoreText();
			    // Debug.Log("Score: " + score);
		    }
		    if (other.gameObject.CompareTag("Trap"))
		    {
			    health -= 1;
			    Debug.Log("Health: " + health);
		    }
		    if (other.gameObject.CompareTag("Goal"))
		    {
			    Debug.Log("You Win!");
		    }
	    }

	    void SetScoreText()
	    {
		    scoreText.text = "Score: " + score;
	    }
}
