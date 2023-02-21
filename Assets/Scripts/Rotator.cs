using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float xSpeed = 45.0f;

	void Update()
	{
		transform.Rotate(xSpeed * Time.deltaTime, 0.0f, 0.0f, Space.Self);
	}
}
