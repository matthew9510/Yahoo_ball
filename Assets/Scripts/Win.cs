using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.CompareTag("End")){
			gameObject.active = false;
			Debug.Log("Win!");
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
}
