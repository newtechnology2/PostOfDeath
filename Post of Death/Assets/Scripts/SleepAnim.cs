using UnityEngine;
using System.Collections;

public class SleepAnim : MonoBehaviour 
{

	// Use this for initialization
	BedFunctions B;
	Animation AnimComponent;

	void Start () 
	{
		B = FindObjectOfType<BedFunctions> ();
		AnimComponent = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (B.NearBed && Keys.SecondaryActionKey.pressed) 
		{
			AnimComponent.Play("SleepAnim");
		}
	}
}
