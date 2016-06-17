﻿#define DEBUG_MODE

using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
#if (DEBUG_MODE)
        if (Input.GetKey(KeyCode.Space))
        {
            Camera.main.orthographicSize = (float)(0.98) * Camera.main.orthographicSize;
        }
#endif
        if(Input.touchCount > 0) {
            Camera.main.orthographicSize = (float)(0.98) * Camera.main.orthographicSize;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
//Input.GetKey("space") || 
// && Input.GetTouch(0).phase == TouchPhase.Moved