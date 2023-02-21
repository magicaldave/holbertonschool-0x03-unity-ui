using UnityEngine;

public class CameraController : MonoBehaviour
{
	// Grab the player GO. There should only be one!!!
	public GameObject player;
	private Vector3 cam_pos = new Vector3(0, 26, 0);
	void Start()
	{
		player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update()
	{
		// I'm kinda skeptical about this approach.
		// I thought assigning the var with the desired variables would work
		// It almost does - the collection doesn't come out as a Vector3
		// Even when built /like/ one - what's the diff?

		// cam_pos = (player.transform.position.x, 26, player.transform.position.z)
		cam_pos = new Vector3(player.transform.position.x, 26, player.transform.position.z);
		transform.position = cam_pos;
	}
}
