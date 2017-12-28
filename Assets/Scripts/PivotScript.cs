using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotScript : MonoBehaviour {

	public float rotateIncrement = 1.5f;
	public float maxTilt = 0.15f;
	private float x = 0;
	private float z = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (transform.rotation.x <= maxTilt) {
				x += rotateIncrement;
				transform.rotation = Quaternion.Euler (x, 0, z);
			}
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (transform.rotation.x >= -maxTilt) {
				x -= rotateIncrement;
				transform.rotation = Quaternion.Euler (x, 0, z);
			}
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (transform.rotation.z <= maxTilt) {
				z += rotateIncrement;
				transform.rotation = Quaternion.Euler (x, 0, z);
			}
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			if (transform.rotation.z >= -maxTilt) {
				z -= rotateIncrement;
				transform.rotation = Quaternion.Euler (x, 0, z);
			}
		}
	}
}
