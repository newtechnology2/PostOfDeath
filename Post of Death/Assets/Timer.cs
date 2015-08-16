using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text Timertext;
	public double timesecs;
	public static bool lost;
	public double LevelTime;
	// Use this for initialization
	void Start () {
		timesecs = DateTime.Now.TimeOfDay.TotalSeconds;
	}
	
	// Update is called once per frame
	void Update () {
		if ((timesecs + LevelTime - DateTime.Now.TimeOfDay.TotalSeconds) >= 0)
			Timertext.text = "Time remaining: " + Mathf.Floor ((float)(timesecs + LevelTime - DateTime.Now.TimeOfDay.TotalSeconds));
		else {
			Timertext.text = "Time out, you're stuck at death world"+'\n'+'\n'+"Game Over";
			lost=true;
		}
		if (timesecs + LevelTime - DateTime.Now.TimeOfDay.TotalSeconds < -5.0)
			Application.LoadLevel ("Menu");
	}
}
