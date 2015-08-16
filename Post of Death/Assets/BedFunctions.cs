using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BedFunctions : MonoBehaviour {
	public Transform camera;
	public Transform bed;
	public float EffectingDistane;
	public float HalfEffectingAngleCos1;
	public Vector3 EffectingDirection;
	public float HalfEffectingAngleCos2;
	public bool NearBed;

	// Use this for initialization
	void Start () 
	{
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
			Keys.KeyText = Keys.KeyText + '\n' + "Press ";
			Keys.KeyText = Keys.KeyText + Keys.PrimaryActionKey.Key.ToString ();
			Keys.KeyText = Keys.KeyText + " to sleep" + '\n' + "Press ";
			Keys.KeyText = Keys.KeyText + Keys.SecondaryActionKey.Key.ToString ();
			Keys.KeyText = Keys.KeyText + " to save game";
			if (Keys.PrimaryActionKey.pressed)
				Guy.StartPuttingShovelOnBack = true;
		} else {
			NearBed = false;
		}
	}
}
