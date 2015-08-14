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

    bool Played = false;

    Transform MainCamera;

    SleepFix House_Programmer;

    public Text CannotSleepMsg;

	void Start () 
	{
		B = FindObjectOfType<BedFunctions>();
		AnimComponent = GetComponent<Animation>();
		PlayerControl = GetComponent<RigidbodyFirstPersonController>();
        House_Programmer = FindObjectOfType<SleepFix>();


        Played = false;

        CannotSleepMsg.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
        //if (!AnimComponent.IsPlaying("SleepAnim") && Played)
      //  {
            //PlayerControl.enabled = true;
      //  }

        if (B.NearBed && Keys.PrimaryActionKey.pressed && !Played && !AnimComponent.IsPlaying("SleepAnim")) 
		{
            if (!House_Programmer.ShouldBeAbleToSleep)
            {
                CannotSleepMsg.text = "Cannot sleep from this position. Try another.";
                return;
            }
            else
                CannotSleepMsg.text = "";


            Debug.Log("Play Sleep Anim");

            AnimComponent["SleepAnim"].speed = +1;
           // AnimComponent["SleepAnim"].time = AnimComponent["SleepAnim"].length;
      
			AnimComponent.Play("SleepAnim");
        
            PlayerControl.enabled = false;

            House_Programmer.ShouldBeAbleToSleep = false;

            Played = true;
		}
       
        if (Keys.PrimaryActionKey.pressed && Played && !AnimComponent.IsPlaying("SleepAnim")) 
        {
            Debug.Log("Reverse Play Sleep Anim");

            AnimComponent["SleepAnim"].speed = -1;
            AnimComponent["SleepAnim"].time = AnimComponent["SleepAnim"].length;

            AnimComponent.Play("SleepAnim");

            PlayerControl.enabled = true;

            Played = false;
        
        }


	}
}
