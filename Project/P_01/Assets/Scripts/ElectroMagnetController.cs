using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 */
public class ElectroMagnetController : MonoBehaviour {

	//Permeability constant
	static float PERMEABILITY = 1.25663753E-6f;

	//How "magnetic" should this object be? required for the magnetic attraction force
	public float magnitude = 1f;

	//Is this magnet on?
	private bool on = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			CalculateForces ();
	}

	public bool Power {
		get {return on;}
		set {on = value;}
	}

	void CalculateForces() {
		float perm = ElectroMagnetController.PERMEABILITY;


		//The sum of all forces that will be added to this rigid body
		Vector3 force_sum = Vector3.zero;

		//Iterate through all objects in the scene tagged "Magnet". Use their magnutude in order
		//to calculate the magnetic force between this object and that.
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Magnet")) {

			//We dont want to use this current object in the calculation. Unity doesn't handle calculating distances between the same object as itself
			if(g != gameObject) {

				if(g.gameObject.GetComponent<ElectroMagnetController> ().enabled) {
					float g_magnitude = g.gameObject.GetComponent<ElectroMagnetController> ().magnitude;
					Vector3 dist = g.transform.position - transform.position;

					float dist_mag = dist.magnitude;

					force_sum += 1000000*dist.normalized*(perm * magnitude * g_magnitude)/(4 * Mathf.PI * dist_mag * dist_mag);
				}
			}

		}

		//Apply the force
		GetComponent<Rigidbody> ().AddForce (force_sum);
	}
}
