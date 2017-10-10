using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Found on the Unity forums. Searched for "How to make an object follow path"
//Link: http://answers.unity3d.com/questions/894796/how-to-make-object-follow-path.html

//What this script  does is make an object follow a set path, given an array of waypoints.
//Whenever this object reaches one waypoint, it starts to move towards the next in the array. 
public class WayPoints : MonoBehaviour {

	// put the points from unity interface
	public Transform[] wayPointList;

	public int currentWayPoint = 0; 
	Transform targetWayPoint;

	public float speed = 4f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// check if we have somewere to move
		if(currentWayPoint < this.wayPointList.Length)
		{
			if(targetWayPoint == null)
				targetWayPoint = wayPointList[currentWayPoint];
			walk();
		}
	}

	void walk(){
		// move towards the target
		transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position,   speed*Time.deltaTime);

		//If target reached, update current target to the next one
		if(transform.position == targetWayPoint.position)
		{
			currentWayPoint ++ ;
			if (currentWayPoint < this.wayPointList.Length) {
				targetWayPoint = wayPointList [currentWayPoint];
			}
		}
	} 
}