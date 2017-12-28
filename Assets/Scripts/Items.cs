using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.CompareTag("Ball")){
			gameObject.SetActive(false);
			Debug.Log("Collected");
		}
	}
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15,30,45)*Time.deltaTime);
	}
}
