using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Author: Leif T. Sundkvist, Julia Duong, Malin Larsson
 * 
 * This script controls the movement of the camera. If this is added to the camera object, the camera will follow the object
 * In the x and y axis, i.e. it won't zoom in or out.
 */
public class CameraScript : MonoBehaviour {
	
	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x, player.position.y, transform.position.z);
	}
}
