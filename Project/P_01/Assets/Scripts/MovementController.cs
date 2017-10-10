using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 * Simple script for using standard input ASDW to move an object. Use keys U and I to zoom in and out, and keys O and P to rotate.
 */
public class MovementController : MonoBehaviour {

	public float speed = 1f;
	public float rotateSpeed = 1f;

	public float zoomspeed = 0.25f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		if(Input.GetKey(KeyCode.P)) {
			transform.RotateAround (transform.position, transform.forward, rotateSpeed);
		}
		if(Input.GetKey(KeyCode.O)) {
			transform.RotateAround (transform.position, transform.forward, -rotateSpeed);
		}

		if(Input.GetKey(KeyCode.U)) {
			transform.position += (new Vector3 (-zoomspeed, 0f, 0f) * Time.deltaTime * speed);
		}
		if(Input.GetKey(KeyCode.I)) {
			transform.position += (new Vector3 (zoomspeed, 0f, 0f) * Time.deltaTime * speed);
		}

		transform.position += (new Vector3 (0f, moveY, -moveX) * Time.deltaTime * speed);
	}
}
