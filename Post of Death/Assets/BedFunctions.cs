using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BedFunctions : MonoBehaviour {
	public Transform camera;
	public Transform bed;
	public Text KeyMessage;
	public float EffectingDistane;
	public float HalfEffectingAngleCos1;
	public Vector3 EffectingDirection;
	public float HalfEffectingAngleCos2;

	public static bool NearBed;

	// Use this for initialization
	void Start () {
		NearBed = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp;
		temp = (bed.position - camera.position);
		float ActualDist;
		ActualDist = temp.magnitude;
		if ( ActualDist< EffectingDistane&&Vector3.Dot(camera.forward,temp)/ActualDist>HalfEffectingAngleCos1&&(Vector3.Dot(temp,EffectingDirection)/ActualDist)/-EffectingDirection.magnitude>HalfEffectingAngleCos2) {
			NearBed = true;
			KeyMessage.text = "Press ";
			KeyMessage.text = KeyMessage.text + Keys.PrimaryActionKey.Key.ToString ();
			KeyMessage.text = KeyMessage.text + " to sleep" + '\n' + "Press ";
			KeyMessage.text = KeyMessage.text + Keys.SecondaryActionKey.Key.ToString ();
			KeyMessage.text = KeyMessage.text + " to save game";
		} else {
			NearBed = false;
			KeyMessage.text="";
		}
	}
}
