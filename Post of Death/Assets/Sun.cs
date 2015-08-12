using UnityEngine;
using System;

public class Sun : MonoBehaviour {
	public Transform SunTransform;
	public Light SunLight;
	public float StartH;
	public float Y_Angle;
	public float Time_Scaler;
	public Color LightColor;
	public Color RiseSetColor;
	public Color OffColor;
	public float Exp;
	
	private float earth_to_sun,earth_radiuse,Height;
	private Vector3 EarthCenterToLight;
	private Vector3 translate,scale;
	private float TheStartCallH;
	
	
	// Use this for initialization
	void Start () {
		earth_radiuse = 6371000f;
		Height = 10000f;
		earth_to_sun=149600000000f;
		EarthCenterToLight.x = 0f;
		EarthCenterToLight.y = 0f;
		EarthCenterToLight.z = -earth_to_sun;
		translate.x=0f;
		translate.y=0f;
		translate.z=0f;
		scale.x=1f;
		scale.y=1f;
		scale.z=1f;
		Time_Scaler = 1f;
		TimeSpan timespan = DateTime.Now.TimeOfDay;
		TheStartCallH = (float)timespan.TotalHours;
		Vector3 temp = EarthCenterToLight;
		temp.y = temp.y - earth_radiuse;
		if (temp.y != 0)
			temp = temp / Mathf.Abs (temp.y) * Height;
		SunTransform.localPosition = temp;
	}
	
	// Update is called once per frame
	void Update () {
		TimeSpan timespan = DateTime.Now.TimeOfDay;
		Matrix4x4 rotate_light= Matrix4x4.zero;
		Vector3 temp;
		rotate_light.SetTRS (translate, Quaternion.Euler (0f, Y_Angle, 0f), scale);
		temp = rotate_light.MultiplyVector(EarthCenterToLight);
		rotate_light.SetTRS (translate, Quaternion.Euler (((float)(timespan.TotalHours - TheStartCallH) * Time_Scaler + StartH) / 12f * 180f - 90f, 0f, 0f), scale);
		temp = rotate_light.MultiplyVector(temp);
		temp.y = temp.y - earth_radiuse;
		if (temp.y != 0f)
			temp = temp / Mathf.Abs (temp.y) * Height;
		SunTransform.localRotation=Quaternion.LookRotation(-Vector3.Normalize(temp));
		SunTransform.localPosition = temp;
		temp = Vector3.Normalize (temp);
		if (temp.y >= 0f)
			SunLight.color = Color.Lerp (RiseSetColor, LightColor, Mathf.Pow (temp.y, Exp));
		else
			SunLight.color = Color.Lerp (RiseSetColor, OffColor, Mathf.Pow (-temp.y, Exp/5f));
		
	}
}
