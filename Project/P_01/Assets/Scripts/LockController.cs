using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 */
public class LockController : MonoBehaviour {

	//What position should this lock move into when activated?
	public Transform dest;

	//How fast should it move?
	public float speed = 0.5f;

	//If it's close enough to the destination, and the difference in distance is less than the limit, stop moving
	public float limit = 0.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(transform.position, dest.position) > limit) {
			transform.position = Vector3.MoveTowards (transform.position, dest.position, speed * Time.deltaTime);
		}
	}
}
