using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class OnGhostAttack : MonoBehaviour 
{

    Ghost GhostScript;
    Animation AnimComponent;
    RigidbodyFirstPersonController PlayerController;

    bool PlayedFallAnim = false;
    bool StoodUp = false;

    float TimeElapsed = 0;

	void Start () 
    {
        GhostScript = FindObjectOfType<Ghost>();
        AnimComponent = GetComponent<Animation>();
        PlayerController = GetComponent<RigidbodyFirstPersonController>();


        PlayedFallAnim = false;
        StoodUp = false;

        TimeElapsed = 0;
	}
	
	
	void Update () 
    {
        if (GhostScript.GhostAttacked && !AnimComponent.IsPlaying("ThrowAnim") && !PlayedFallAnim)
        {

            PlayerController.enabled = false;

            AnimComponent.Play("ThrowAnim");

            PlayedFallAnim = true;

            StoodUp = false;
        }

        if (PlayedFallAnim && !AnimComponent.IsPlaying("ThrowAnim") && !AnimComponent.IsPlaying("StandUpAnim"))
        {
            TimeElapsed += Time.deltaTime;

            if (TimeElapsed >= 3.0f)
            {
                AnimComponent.Play("StandUpAnim");

                PlayedFallAnim = false;

                StoodUp = true;

                TimeElapsed = 0;
            }
        }

        if (StoodUp)
            PlayerController.enabled = true;
	}
}
