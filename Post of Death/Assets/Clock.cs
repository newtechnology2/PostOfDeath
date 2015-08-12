using UnityEngine;
using UnityEngine.UI;
using System;

public class Clock : MonoBehaviour {
	public Text Text;
	public float StartH;
	public float Time_Scaler;

	private DateTime TheStartCallTime;
	private static TimeSpan Time;
	// Use this for initialization
	void Start () {
		Time_Scaler = 1;
		TheStartCallTime = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		DateTime temp = DateTime.Now;
		Time = temp - TheStartCallTime;
		Time = TimeSpan.FromHours (Time.TotalHours*(double)Time_Scaler);
		Time = Time.Add (TimeSpan.FromHours ((double)StartH));

		Text.text = "Day: " + Time.Days + "    " + Time.Hours + ":" + Time.Minutes + ":" + Time.Seconds;
	}

	public static TimeSpan GetTime()
	{
		return Time;
	}
}
