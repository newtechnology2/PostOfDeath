using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class SleepInDitch : MonoBehaviour 
{

    Animation AnimComponent;
    RigidbodyFirstPersonController Controller;
    bool AnimWasPlayed = false;

	void Start () 
    {
        AnimComponent = GetComponent<Animation>();
        Controller = GetComponent<RigidbodyFirstPersonController>();
        AnimWasPlayed = false;
	}
	

	void Update () 
    {
       if (Dig.LayDownInTheDitch)
       {
           Controller.enabled = false;

           AnimComponent.Play("SleepDitch");

           AnimWasPlayed = true;
       }

        if (AnimWasPlayed && !AnimComponent.IsPlaying("SleepDitch"))
        {
            //Controller.enabled = true;

            AnimWasPlayed = false;
        }

	}
}
