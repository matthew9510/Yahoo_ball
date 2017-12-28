using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollUIElement : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update () {
	    RectTransform[] position = this.GetComponentsInChildren<RectTransform>();
        for(var i = 3; i < position.Length; i++) 
            position[i].localPosition += Vector3.up;
    }
}
