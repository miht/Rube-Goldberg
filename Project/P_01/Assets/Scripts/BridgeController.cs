using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 * This script makes the object rotate for a given amount of degrees
 * with a given rotational speed, around a designated axis. 
 */
public class BridgeController : MonoBehaviour {

	//What axis do we want it to rotate around?
	public Vector3 axis;

	//How many degrees the object is supposed to rotate
	public float rotationAmount = 90f;

	//How fast should it rotate?
	public float rotationSpeed = 1f;


	//If it's enabled, rotate it
	bool enabled = false;

	//Keep track of how much it has rotated, so we know when to stop it
	float counter = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//If enabled, rotate the object around the given axis, and increment the counter. 
		//Elsewise do nothing
		if(enabled)
		{
			transform.RotateAround (transform.position, axis, rotationSpeed * Time.deltaTime);
			counter += rotationSpeed * Time.deltaTime;
		}		
		if(counter >= rotationAmount) {
			enabled = false;
		}
	}

	//When this object's collider receives a collision, it means it should start rotating. set enabled to true => start rotating.
	//counter must be less than the desired amount of rotation, or else it won't budge.
	void OnCollisionEnter(Collision coll) {
		Debug.Log ("Hello");	
		if(counter < rotationAmount) {
			enabled = true;

		}
	}
}
