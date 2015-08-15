using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class CharacterAnims : MonoBehaviour 
{

    Animator AnimatorComponent;
    RigidbodyFirstPersonController PlayerController;

    void Start ()
    {
        AnimatorComponent = GetComponent<Animator>();
        PlayerController = FindObjectOfType<RigidbodyFirstPersonController>();
    }

	void Update () 
    {
        if (!Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.S) && !Input.GetKeyDown(KeyCode.A) && !Input.GetKeyDown(KeyCode.D))
            AnimatorComponent.SetFloat("Speed", 0.0f);

       if (Input.GetKeyUp(KeyCode.Space))
       {
           //don't play mid-air animation when we jump
           AnimatorComponent.SetBool("Grounded", true);
       }
       else
           AnimatorComponent.SetBool("Grounded", PlayerController.Grounded);



       if (Input.GetKey(KeyCode.W))
       {
           float stamina = (int)PlayerController.movementSettings.GetStaminaBarValue();

           //convert to [0, 1] range
           stamina /= 5;

           if (Input.GetKey(KeyCode.LeftShift) && !PlayerController.movementSettings.RegenerateStamina)
           {
               AnimatorComponent.SetFloat("Speed", stamina + 0.5f);
           }
           else
               AnimatorComponent.SetFloat("Speed", 0.5f);
        
       }

       if (Input.GetKey(KeyCode.S))
       {
           AnimatorComponent.SetFloat("Speed", -0.5f);
       }

        if (Input.GetKey(KeyCode.Space))
        {
            AnimatorComponent.SetTrigger("Jump");
        }



	}
}
