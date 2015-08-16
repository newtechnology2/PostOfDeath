﻿using UnityEngine;
using System.Collections;

public class LightFLash : MonoBehaviour {

	// Use this for initialization
	public float distance_start;
	public CanvasGroup flash_canvas; 

	public void change_alpha()
	{
		float alpha = flash_canvas.alpha;
		GameObject go = GameObject.Find ("Body");
		float distance = Vector3.Distance (go.transform.position, gameObject.transform.position);
		alpha = ( (distance_start-distance)/distance_start ) * 255;

		flash_canvas.alpha = alpha;
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		change_alpha ();
	}
}