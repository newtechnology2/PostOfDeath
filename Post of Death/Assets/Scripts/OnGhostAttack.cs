using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class OnGhostAttack : MonoBehaviour 
{

    Ghost GhostScript;
    Animation AnimComponent;
    RigidbodyFirstPersonController PlayerController;
    Transform Child_Max;


    bool PlayedFallAnim = false;
    bool StandingUp = false;
    bool foo = false;

    float TimeElapsed = 0;

	void Start () 
    {
        GhostScript = FindObjectOfType<Ghost>();
        AnimComponent = GetComponent<Animation>();
        PlayerController = GetComponent<RigidbodyFirstPersonController>();
        Child_Max = transform.FindChild("MAX");

        PlayedFallAnim = false;
        StandingUp = false;
        foo = false;

        TimeElapsed = 0;
	}
	
	
	void Update () 
    {
        if (GhostScript.GhostAttacked && !AnimComponent.IsPlaying("ThrowAnim") && !PlayedFallAnim)
        {
            Child_Max.gameObject.SetActive(false);

            PlayerController.enabled = false;

            AnimComponent.Play("ThrowAnim");

            PlayedFallAnim = true;

            StandingUp = false;
        }

        if (PlayedFallAnim && !AnimComponent.IsPlaying("ThrowAnim") && !AnimComponent.IsPlaying("StandUpAnim"))
        {
            TimeElapsed += Time.deltaTime;

            if (TimeElapsed >= 3.0f)
            {
                AnimComponent.Play("StandUpAnim");

                PlayedFallAnim = false;

                StandingUp = true;

                TimeElapsed = 0;
            }
        }

        if (StandingUp)
        {
            PlayerController.enabled = true;

            foo = true;
        }

        if (foo)
        {
            if (!AnimComponent.IsPlaying("StandUpAnim"))
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                {
                    Child_Max.gameObject.SetActive(true);
                     foo = false;
                }
            }
        }
	}
}
