using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class SleepAnim : MonoBehaviour 
{

	// Use this for initialization
	BedFunctions B;
	Animation AnimComponent;
	RigidbodyFirstPersonController PlayerControl;

	void Start () 
	{
		B = FindObjectOfType<BedFunctions> ();
		AnimComponent = GetComponent<Animation> ();
		PlayerControl = GetComponent<RigidbodyFirstPersonController> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
        if (!AnimComponent.IsPlaying("SleepAnim"))
        {
            PlayerControl.enabled = true;
        }

		if (B.NearBed && Keys.PrimaryActionKey.pressed) 
		{
			AnimComponent.Play("SleepAnim");
        
            PlayerControl.enabled = false;
		}


	}
}
