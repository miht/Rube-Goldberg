using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogwheelController : MonoBehaviour {

	public float rotate_speed = 1f;
	private float x_rotation = 0f;


	public Vector3 axis;

	// Use this for initialization
	void Start () {
	}

	void FixedUpdate() {
		transform.RotateAround (transform.position, axis, rotate_speed * Time.deltaTime);
		x_rotation += rotate_speed * Time.deltaTime;

	}
	// Update is called once per frame
	void Update () {
	}

	public float X_Rotation {
		set{x_rotation = value;}
		get{return x_rotation;}
	}
}
