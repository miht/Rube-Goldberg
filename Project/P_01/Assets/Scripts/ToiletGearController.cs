using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletGearController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (transform.localEulerAngles);

		float rotationX = transform.localEulerAngles.x;
		//rotationX = Mathf.Clamp (rotationX, 360f, 270f);

		//transform.localEulerAngles =  new Vector3(rotationX, 0f, 0f);
	}
}
