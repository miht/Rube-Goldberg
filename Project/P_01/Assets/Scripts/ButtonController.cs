using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 */
public class ButtonController : MonoBehaviour {

	//What lock object should this button enable?
	public GameObject lock_;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {
		//Simple. When this button is pressed, get the assigned lock's lock script and enable it
		lock_.GetComponent<LockController>().enabled = true;
	}
}
