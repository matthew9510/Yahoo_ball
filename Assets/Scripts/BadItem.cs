using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadItem : MonoBehaviour {

	private float scaling = 0.001f;
	private Vector3 minScale = new Vector3(.125f,.125f,0.125f);
	private Vector3 currentScale = new Vector3(0,0,0);
	private Vector3 maxScale = new Vector3(.15f,.15f,.15f);
	private int flip = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentScale.x <= maxScale.x && flip == 0) {
			transform.localScale += new Vector3 (scaling, scaling, scaling);
			currentScale = transform.localScale;
			if (currentScale.x >= maxScale.x)
				flip = 1;
		}
		if (currentScale.x >= minScale.x && flip == 1){
			transform.localScale -= new Vector3 (scaling, scaling, scaling);
			currentScale = transform.localScale;
			if (currentScale.x <= minScale.x)
				flip = 0;
		}
	}
}
