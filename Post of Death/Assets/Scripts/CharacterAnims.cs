using UnityEngine;
using System.Collections;

public class CharacterAnims : MonoBehaviour 
{

    Animation AnimComponent;

    bool PlayWalk = false;
    bool PlayJump = false;

    void Start ()
    {
        AnimComponent = FindObjectOfType<Animation>();
    }

	void Update () 
    {
        AnimComponent.CrossFade("idle");

        if (Input.GetKey(KeyCode.W))
        {
           AnimComponent.CrossFade("walk");
        }

 //       if (Input.GetKey(KeyCode.S))
  //      {
  //          AnimComponent["walk"].speed = -1;
  //   
  //          AnimComponent.CrossFade("walk");
  //      }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayJump = true;
           
        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            PlayJump = false;
        }


        if (PlayJump)
        {
            if (AnimComponent.IsPlaying("jump"))
            {
                if (AnimComponent["jump"].normalizedTime >= 0.99f)
                {
                    PlayJump = false;
                    return;
                }
            }

            AnimComponent.CrossFade("jump");
        }
	}
}
