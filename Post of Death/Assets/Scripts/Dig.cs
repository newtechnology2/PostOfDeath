using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dig : MonoBehaviour {

	public bool ShovelOn;
	public Transform CameraTransform;
	public Text KeyMessage;

	public int UnwantedAraCount;
	public Transform UnwantedAra1Transform;
	public Transform UnwantedAra2Transform;
	public Transform UnwantedAra3Transform;
	public Transform UnwantedAra4Transform;
	public Transform UnwantedAra5Transform;
	public Transform UnwantedAra6Transform;
	public Transform UnwantedAra7Transform;
	public Transform UnwantedAra8Transform;
	public Transform UnwantedAra9Transform;
	public Transform UnwantedAra10Transform;
	public float UnwantedAra1Radius;
	public float UnwantedAra2Radius;
	public float UnwantedAra3Radius;
	public float UnwantedAra4Radius;
	public float UnwantedAra5Radius;
	public float UnwantedAra6Radius;
	public float UnwantedAra7Radius;
	public float UnwantedAra8Radius;
	public float UnwantedAra9Radius;
	public float UnwantedAra10Radius;

	private bool InUnwantedArea;

	// Use this for initialization
	void Start () {
		KeyMessage.text="";
	}
	
	// Update is called once per frame
	void Update () {
		InUnwantedArea=false;
		if (UnwantedAraCount >= 1)
		if ((CameraTransform.position - UnwantedAra1Transform.position).magnitude <= UnwantedAra1Radius) {
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 2)
		if ((CameraTransform.position-UnwantedAra2Transform.position).magnitude<=UnwantedAra2Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 3)
		if ((CameraTransform.position-UnwantedAra3Transform.position).magnitude<=UnwantedAra3Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 4)
		if ((CameraTransform.position-UnwantedAra4Transform.position).magnitude<=UnwantedAra4Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 5)
		if ((CameraTransform.position-UnwantedAra5Transform.position).magnitude<=UnwantedAra5Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 6)
		if ((CameraTransform.position-UnwantedAra6Transform.position).magnitude<=UnwantedAra6Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 7)
		if ((CameraTransform.position-UnwantedAra7Transform.position).magnitude<=UnwantedAra7Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 8)
		if ((CameraTransform.position-UnwantedAra8Transform.position).magnitude<=UnwantedAra8Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 9)
		if ((CameraTransform.position-UnwantedAra9Transform.position).magnitude<=UnwantedAra9Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 10)
		if ((CameraTransform.position-UnwantedAra10Transform.position).magnitude<=UnwantedAra10Radius){
			if (!InUnwantedArea)
				KeyMessage.text="";
			InUnwantedArea=true;
		}
		if (ShovelOn&&!InUnwantedArea)
		{
			KeyMessage.text = "Press ";
			KeyMessage.text = KeyMessage.text + Keys.PrimaryActionKey.Key.ToString ();
			KeyMessage.text = KeyMessage.text + " to dig";
		}
	}
}
