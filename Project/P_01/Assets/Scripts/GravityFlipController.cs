using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 * This script is attached to a gravity field object, entitled "GF#" in the scene.
 * Whenever an object passes through this object's collider, it triggers the OnTriggerExit method defined in this script.
 * When that happens, the object that entered the gravity field will have its "GravityShift" script enabled or disabled.
 */
public class GravityFlipController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

	void OnTriggerEnter(Collider coll) {
		GravityShift gs = coll.gameObject.GetComponent<GravityShift> ();
		if(gs != null) {
			gs.enabled = !gs.enabled;
		}
	}
}
