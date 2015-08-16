using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class OnGhostAttack : MonoBehaviour 
{

    Ghost GhostScript;
    Animation AnimComponent;
    RigidbodyFirstPersonController PlayerController;
    Transform Child_Max;

    Animator PlayerAnimator;
    Camera MainCamera;

    PlayerProperties PP;

    bool PlayedFallAnim = false;
    bool StandingUp = false;
    bool foo = false;
    bool Dead = false;

    EscapeMenu EscMenu;

    float TimeElapsed = 0;

	void Start () 
    {
        GhostScript = FindObjectOfType<Ghost>();
        AnimComponent = GetComponent<Animation>();
        PP = FindObjectOfType<PlayerProperties>();
        PlayerController = GetComponent<RigidbodyFirstPersonController>();
        EscMenu = FindObjectOfType<EscapeMenu>();

        MainCamera = PlayerController.gameObject.transform.FindChild("MainCamera").GetComponent<Camera>();
        Child_Max = transform.FindChild("Body").FindChild("MAX");

        PlayerAnimator = Child_Max.GetComponent<Animator>();

        PlayedFallAnim = false;
        StandingUp = false;
        foo = false;
        Dead = false;

        TimeElapsed = 0;
	}
	
	
	void Update () 
    {
        if (Dead)
        {
            EscMenu.EnableMenu = true;
            EscMenu.DisableInput = true;


            EscMenu.GameOverText.SetActive(true);
            EscMenu.PlayAgainButton.SetActive(true);

            MainCamera.transform.localPosition = new Vector3(MainCamera.transform.localPosition.x, MainCamera.transform.localPosition.y, -4.5f);


            return;
        }


        if (GhostScript.GhostAttacked && !AnimComponent.IsPlaying("ThrowAnim") && !PlayedFallAnim)
        {
            if (PP.GetHealthFromBar() == 0 && !Dead)
            {
                Debug.Log("TTT");

                PlayerController.enabled = false;


                PlayerAnimator.SetTrigger("Die");

                Dead = true;

                return;
            }

            Child_Max.gameObject.SetActive(false);

            PlayerController.enabled = false;

            AnimComponent.Play("ThrowAnim");

            PlayedFallAnim = true;

            StandingUp = false;
        }

        if (PlayedFallAnim && !AnimComponent.IsPlaying("ThrowAnim") && !AnimComponent.IsPlaying("StandUpAnim"))
        {
            TimeElapsed += Time.deltaTime;

            PlayerController.enabled = false;

            if (TimeElapsed >= 3.0f)
            {
                AnimComponent.Play("StandUpAnim");

                PlayedFallAnim = false;

                StandingUp = true;

                TimeElapsed = 0;
            }
        }

        if (StandingUp && !AnimComponent.IsPlaying("StandUpAnim"))
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
