using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class SleepAnim : MonoBehaviour 
{

	// Use this for initialization
	BedFunctions B;
	Animation AnimComponent;
	RigidbodyFirstPersonController PlayerControl;
    PlayerProperties PP;
    GameObject Body;

    bool Played = false;

    bool PlayedReverseAnim = false;

    Transform MainCamera;

    SleepFix House_Programmer;

    public Text CannotSleepMsg;

    float TimeElapsed = 0;

	Clock thetimeclock;

	void Start () 
	{
		B = FindObjectOfType<BedFunctions>();
		AnimComponent = GetComponent<Animation>();
		PlayerControl = GetComponent<RigidbodyFirstPersonController>();
        House_Programmer = FindObjectOfType<SleepFix>();
        PP = FindObjectOfType<PlayerProperties>();

        Body = this.gameObject.transform.FindChild("Body").gameObject;

        Played = false;

        PlayedReverseAnim = false;

        CannotSleepMsg.text = "";
		thetimeclock = FindObjectOfType<Clock>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        //if (!AnimComponent.IsPlaying("SleepAnim") && Played)
      //  {
            //PlayerControl.enabled = true;
      //  }

        if (B.NearBed && Keys.SleepActionKey.pressed && !Played && !AnimComponent.IsPlaying("SleepAnim")) 
		{

            if (!House_Programmer.ShouldBeAbleToSleep)
            {
                CannotSleepMsg.text = "Cannot sleep from this position. Try another.";
                return;
            }
            else
                CannotSleepMsg.text = "";

            Body.SetActive(false);

            Debug.Log("Play Sleep Anim");

            AnimComponent["SleepAnim"].speed = +1;
      
			AnimComponent.Play("SleepAnim");
        
            PlayerControl.enabled = false;

            House_Programmer.ShouldBeAbleToSleep = false;

            Played = true;
		}

        if (Keys.SleepActionKey.pressed && Played && !AnimComponent.IsPlaying("SleepAnim")) 
        {
			thetimeclock.SetPastTime(thetimeclock.GetPastTime()+8.0);
            Debug.Log("Reverse Play Sleep Anim");

            Body.SetActive(false);

            AnimComponent["SleepAnim"].speed = -1;
            AnimComponent["SleepAnim"].time = AnimComponent["SleepAnim"].length;

            AnimComponent.Play("SleepAnim");

            Played = false;

            PlayedReverseAnim = true;
        }

        if (PlayedReverseAnim && !AnimComponent.IsPlaying("SleepAnim"))
        {

            PlayerControl.enabled = true;

            Body.SetActive(true);

            PlayedReverseAnim = false;
        }


        if (Played && !PlayedReverseAnim)
        {
            TimeElapsed += Time.deltaTime;

            int NoBarsToBeAdded = (int)Mathf.Floor(TimeElapsed);

            PP.SetHealth(NoBarsToBeAdded);
            PP.SetStamina(NoBarsToBeAdded);
        }
        else
        {
            TimeElapsed = 0;
        }
	}
}
