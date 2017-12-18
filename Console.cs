using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float location = 3.0f; //Distance in meters
		float homeLocation = 2.1f;
		float distance = homeLocation - location;

		print("Hello World!");
		print("A game where you need to find your way back.");
		print("Distance: " + distance);

		if (location > homeLocation) {
			print("Go back to get home");
		}
		if (location < homeLocation) {
			print("Go forward to get home");
		}
		if (location == homeLocation) {
			print("I am at home");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
