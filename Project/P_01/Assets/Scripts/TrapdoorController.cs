using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorController : MonoBehaviour {

	Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position != pos) {
			transform.position = pos;
		}
	}

	void FixedUpdate() {
		
	}
}
