using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class DitchJumpOut : MonoBehaviour 
{
    Animation AnimComponent;


    RigidbodyFirstPersonController Controller;

    bool PlayedAnim = false;

	void Start () 
    {
        AnimComponent = FindObjectOfType<Animation>();
        Controller = FindObjectOfType<RigidbodyFirstPersonController>();

        PlayedAnim = false;
	}
	
	
	void Update () 
    {
        if (Dig.GetOutTheDitch && !PlayedAnim)
        {
            AnimComponent.Play("DitchJumpOut");

            PlayedAnim = true;

            Controller.enabled = false;
        }

        if (PlayedAnim && !AnimComponent.IsPlaying("DitchJumpOut"))
        {
       
            PlayedAnim = false;

            this.gameObject.transform.localPosition = new Vector3(this.gameObject.transform.localPosition.x, this.gameObject.transform.localPosition.y, this.gameObject.transform.localPosition.z - 5.0f);
            this.gameObject.transform.FindChild("MainCamera").localPosition = new Vector3(0.0f, 0.952f, 0.0f);
           
            Controller.enabled = true;
        }
	}
}
