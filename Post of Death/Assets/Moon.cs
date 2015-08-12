using UnityEngine;
using System;

public class Moon : MonoBehaviour {
	public Transform MoonTransform;
	public Transform MoonBillboardTransform;
	public float StartH;
	public float Y_Angle;
	public float Time_Scaler;
	public float moon_sun_rise_DT;
	
	private float earth_to_moon,earth_radiuse,Height;
	private Vector3 EarthCenterToLight;
	private Vector3 translate,scale;
	private float TheStartCallH;
	
	
	// Use this for initialization
	void Start () {
		earth_radiuse = 6371000f;
		Height = 10000f;
		earth_to_moon=384400000f;
		EarthCenterToLight.x = 0f;
		EarthCenterToLight.y = 0f;
		EarthCenterToLight.z = -earth_to_moon;
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
		MoonTransform.localPosition = temp;
	}
	
	// Update is called once per frame
	void Update () {
		TimeSpan timespan = DateTime.Now.TimeOfDay;
		Matrix4x4 rotate_light= Matrix4x4.zero;
		Vector3 temp;
		rotate_light.SetTRS (translate, Quaternion.Euler (0f, Y_Angle, 0f), scale);
		temp = rotate_light.MultiplyVector(EarthCenterToLight);
		rotate_light.SetTRS (translate, Quaternion.Euler (((float)(timespan.TotalHours - TheStartCallH) * Time_Scaler + StartH - moon_sun_rise_DT) / 12f * 180f - 90f, 0f, 0f), scale);
		temp = rotate_light.MultiplyVector(temp);
		temp.y = temp.y - earth_radiuse;
		if (temp.y != 0)
			temp = temp / Mathf.Abs (temp.y) * Height;
		MoonTransform.localRotation=Quaternion.LookRotation(-Vector3.Normalize(temp));
		MoonTransform.localPosition = temp;
		MoonBillboardTransform.localRotation = MoonTransform.localRotation;
		MoonBillboardTransform.localPosition = Vector3.Normalize(temp)*1000;
	}
}
