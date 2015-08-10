using UnityEngine;
using System.Collections;

public class ButtonAnimation : MonoBehaviour
{

    bool Play = false;
    bool ReversePlay = false;

    AudioSource buttonSound;

    void Start()
    {
        buttonSound = FindObjectOfType<AudioSource>();
    }

    public void PlayButtonAnimation()
    {
        Play = true;
    }

    public void PlayButtonAnimationReverse()
    {
        ReversePlay = true;
       
    }

    public void PlayButtonSound()
    {
        buttonSound.Play();
    }

    void Update()
    {
        if (Play)
        {
           // bool b = GetComponent<Animation>().IsPlaying("ButtonAnim");
            
           // if (!b)
            {
                DoPlayAnimation();
              
            }
        }

        if (ReversePlay)
        {
           // bool b = GetComponent<Animation>().IsPlaying("ButtonAnim");

            //if (!b)
            {
                DoReverseAnimation();
            }
        }
    }
	
    void DoPlayAnimation()
    {
        GetComponent<Animation>()["ButtonAnim"].speed = +1;

        GetComponent<Animation>()["ButtonAnim"].time = GetComponent<Animation>()["ButtonAnim"].length;

        GetComponent<Animation>().Play("ButtonAnim");

        Play = false;
    }

    void DoReverseAnimation()
    {
        GetComponent<Animation>()["ButtonAnim"].speed = -1;

        GetComponent<Animation>()["ButtonAnim"].time = GetComponent<Animation>()["ButtonAnim"].length;

        GetComponent<Animation>().Play("ButtonAnim");

        ReversePlay = false;
    }

   
}
