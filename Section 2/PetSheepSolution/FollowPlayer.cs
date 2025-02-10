//Attach this code to the sheep.
//Set the goal of this script, in the inspector to
//be the fps controller

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script doesn't require a rigidbody
//but this is here to make sure you
//add one to the cube along with this code
[RequireComponent(typeof(Rigidbody))]

public class FollowPlayer : MonoBehaviour {

	public float speed = 2.0f; //the movement speed of the sheep
	public float accuracy = 5.0f; //how close the the player the sheep will get before stopping

	//Drag and drop your FPSController from the Hierarchy
	//onto this goal in the inspector for the cube to follow.
	public Transform goal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt(goal.position);
		Vector3 direction = goal.position - this.transform.position;
		if(direction.magnitude > accuracy)
			this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
	}
}
