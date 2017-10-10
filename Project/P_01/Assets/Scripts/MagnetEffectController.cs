using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 */
public class MagnetEffectController : MonoBehaviour {

	public Material non_emissive_steel;
	public Material emissive_steel;

	//Powered on or off?
	private bool power = false;

	MeshRenderer mr;

	// Use this for initialization
	void Start () {
		mr = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		//If space button pressed, activate this script
		if(Input.GetKeyDown(KeyCode.Space)) {
			power = !power;
			GetComponent<ElectroMagnetController> ().Power = power;

		}


	}
}
