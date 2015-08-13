using UnityEngine;
using System.Collections;

public class SleepAnim : MonoBehaviour 
{

	// Use this for initialization
	BedFunctions BedFunc;
	Animation AnimComponent;

	void Start () 
	{
		BedFunc = FindObjectOfType<BedFunc> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (BedFunc.NearBed && Keys.SecondaryActionKey.pressed) 
		{
			AnimComponent.Play("SleepAnim");
		}
	}
}
