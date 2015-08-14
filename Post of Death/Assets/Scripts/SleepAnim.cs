using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class SleepAnim : MonoBehaviour 
{

	// Use this for initialization
	BedFunctions B;
	Animation AnimComponent;
	RigidbodyFirstPersonController PlayerControl;

    bool Played = false;

    Transform MainCamera;

	void Start () 
	{
		B = FindObjectOfType<BedFunctions> ();
		AnimComponent = GetComponent<Animation> ();
		PlayerControl = GetComponent<RigidbodyFirstPersonController> ();

        Played = false;
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
            Debug.Log("Play Sleep Anim");

            AnimComponent["SleepAnim"].speed = +1;
           // AnimComponent["SleepAnim"].time = AnimComponent["SleepAnim"].length;
      
			AnimComponent.Play("SleepAnim");
        
            PlayerControl.enabled = false;

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
