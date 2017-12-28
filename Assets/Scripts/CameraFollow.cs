using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject sphere;

    private Vector3 offset;


	void Start () {
        offset = transform.position - sphere.transform.position;
	}
	
	
	void Update () {
        transform.position = sphere.transform.position + offset;
		
	}
}
