using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Author: Leif T. Sundkvist, Julia Duong, Malin Larsson 
 * 
 * This script works as an anti-gravitational script that, when enabled, overrides the object's rigidbody's gravitational
 *  force. 
 */
public class GravityShift : MonoBehaviour {

	Rigidbody rb;

	//Simulate Unity's angular drag.
	public float angularDrag = 0.2f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	/* When enabled, disable the gravity for this rigid body, since the gravity constant in the rigid body can't be changed.
	 * Instead, calculate our own force and apply it manually in the FixedUpdate method
	 */
	void OnEnable() {
		rb = GetComponent<Rigidbody> ();
		rb.useGravity = false;
	}

	/* When disabled, activate the normal gravity again
	 */
	void OnDisable() {
		rb.useGravity = true;
	}

	// Update is called once per frame
	void Update () {

	}

	//Add a force that is 
	void FixedUpdate() {
		//Add the force as an accelerating force
		rb.AddForce (Physics.gravity * -1f, ForceMode.Acceleration);
		rb.angularVelocity *= (1 - angularDrag);
	}
}
