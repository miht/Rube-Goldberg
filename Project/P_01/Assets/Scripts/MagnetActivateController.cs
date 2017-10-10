using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 * This script activates/deactivates a given magnet and is to be given to a button, hence the pressed bool value.
 */
public class MagnetActivateController : MonoBehaviour {

	//What magnet object should this script activate?
	public GameObject magnet;
	bool pressed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {
		//If this button hasn't been pressed already, activate the magnet's waypoint script and its
		//electro magnetic properties
		if(!pressed) {
			ElectroMagnetController mag = magnet.GetComponentInChildren<ElectroMagnetController> ();
			magnet.GetComponent<WayPoints> ().enabled = !magnet.GetComponent<WayPoints> ().enabled;
			mag.enabled = !mag.enabled;

			pressed = true;
		}


	}
}
