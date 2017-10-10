using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonController : MonoBehaviour {

	public float amplitude = 1f;
	public float rate = 1f;
	public float phi = 0f;

	public Transform cogwheel;

	public float offset = 0f;
	public float angle_offset = 0f;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate() {
		float x_rotation = cogwheel.GetComponent<CogwheelController> ().X_Rotation;
		float pos_offset = Mathf.Sin(Mathf.Deg2Rad * (x_rotation + angle_offset)* rate) * amplitude;

		//float offset = amplitude * Mathf.Sin (counter*2*Mathf.PI*frequency + phi);

		transform.position = new Vector3 (transform.position.x, transform.position.y , offset + pos_offset);
	}

	// Update is called once per frame
	void Update () {

	}
}
