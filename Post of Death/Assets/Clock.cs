﻿using UnityEngine;
using UnityEngine.UI;
using System;

public class Clock : MonoBehaviour {
	public Text Text;
	public double StartH;
	public double Time_Scaler;

	public double HToTheGame;

	private DateTime TheStartCallTime;

	private static TimeSpan Time;
	// Use this for initialization
	void Start () {
		Time_Scaler = 60;
		TheStartCallTime = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		DateTime temp = DateTime.Now;
		Time = temp - TheStartCallTime;
		Time = TimeSpan.FromHours (Time.TotalHours * Time_Scaler);
		Time = Time.Add (TimeSpan.FromHours (StartH + HToTheGame));

		Text.text = "Day: " + Time.Days + "    " + Time.Hours + ":" + Time.Minutes + ":" + Time.Seconds;
	}

	//get the time
	public static TimeSpan GetTime()
	{
		return Time;
	}

	//set the past time
	public void SetPastTime(double hours)
	{
		HToTheGame=hours;
	}

	//set the past time
	public double GetPastTime()
	{
		return HToTheGame-StartH;
	}
}
