using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour {

	private float maxTilt = 0.05f;
	private float tilt = 5;
	private float flip = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.rotation.x <= maxTilt && flip == 0){
			transform.Rotate (new Vector3 (tilt,0,0)*Time.deltaTime);
			if(transform.rotation.x >= maxTilt)
				flip = 1;
		}else if(transform.rotation.z <= maxTilt && flip == 1){
			transform.Rotate (new Vector3 (0,0,tilt)*Time.deltaTime);
			if(transform.rotation.z >= maxTilt)
				flip = 2;
		}else if(transform.rotation.x >= -maxTilt && flip == 2){
			transform.Rotate (new Vector3 (-tilt,0,0)*Time.deltaTime);
			if(transform.rotation.x <= -maxTilt)
				flip = 3;
		}else if(transform.rotation.z >= -maxTilt && flip == 3){
			transform.Rotate (new Vector3 (0,0,-tilt)*Time.deltaTime);
			if(transform.rotation.z <= -maxTilt)
				flip = 0;
		}
	}
}
