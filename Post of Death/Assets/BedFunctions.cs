using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BedFunctions : MonoBehaviour {
	public Transform camera;
	public Transform bed;
	public Text KeyMessage;
	public float distane;

	public static bool NearBed;

	// Use this for initialization
	void Start () {
		NearBed = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp;
		temp = (bed.position - camera.position);
		distane = temp.magnitude;
		if ( distane< 2.0f&&Vector3.Dot(camera.forward,temp)/distane>0.6) {
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
