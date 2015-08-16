using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class SleepInDitch : MonoBehaviour 
{

    Animation AnimComponent;
    RigidbodyFirstPersonController Controller;
    bool AnimWasPlayed = false;
    public bool FinishedPlayingAnimation = false;
    GameObject Body;

	void Start () 
    {
        AnimComponent = GetComponent<Animation>();
        Controller = GetComponent<RigidbodyFirstPersonController>();
        Body = this.gameObject.transform.FindChild("Body").gameObject;

        AnimWasPlayed = false;
        FinishedPlayingAnimation = false;
	}
	

	void Update () 
    {
       if (Dig.LayDownInTheDitch)
       {
           Controller.enabled = false;

           Body.SetActive(false);

           AnimComponent.Play("SleepDitch");

           AnimWasPlayed = true;
       }

        if (AnimWasPlayed && !AnimComponent.IsPlaying("SleepDitch"))
        {
            //Controller.enabled = true;

            AnimWasPlayed = false;

            FinishedPlayingAnimation = true;
        }

	}
}
