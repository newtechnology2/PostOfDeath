using UnityEngine;
using System.Collections;

public class ShovelAnimation : MonoBehaviour 
{

    public GameObject Shovel01;
    public GameObject Shovel02;

    Animation AnimComponent;

    bool DigAnimWasPlayed = false;
    bool FillAnimWasPlayed = false;

    bool PutShovelbackAnimWasPlayed = false;
    bool PutShovelbackAnimReverseWasPlayed = false;

    bool foo = false;
	void Start () 
    {
        Shovel02.SetActive(false);
        Shovel01.SetActive(true);

        AnimComponent = GetComponent<Animation>();

        DigAnimWasPlayed = false;
        FillAnimWasPlayed = false;
        PutShovelbackAnimWasPlayed = false;
        PutShovelbackAnimReverseWasPlayed = false;

        foo = false;
	}
	
	
	void Update () 
    {
        if (Dig.PlayTheDigAnim)
        {
            Shovel02.SetActive(true);
            Shovel01.SetActive(false);

            AnimComponent["DigAnim"].speed = +2;

            AnimComponent.Play("DigAnim");

            DigAnimWasPlayed = true;
        }

        if (Guy.PuttingShovelOnBack)
        {
            Shovel02.SetActive(true);
            Shovel01.SetActive(false);

            AnimComponent["PutShovelBack"].speed = +1;

            AnimComponent.Play("PutShovelBack");

            PutShovelbackAnimWasPlayed = true;

            Guy.PuttingShovelOnBack = false;
        }

        if (Guy.TakingShovelInHands && !foo && !PutShovelbackAnimWasPlayed)
        {
            Debug.Log("OK");

            Shovel02.SetActive(true);
            Shovel01.SetActive(false);

            AnimComponent["PutShovelBack"].speed = -1;

            AnimComponent.Play("PutShovelBack");

            foo = true;

            PutShovelbackAnimReverseWasPlayed = true;

        }

        if (Dig.PlayTheFillAnim)
        {
            Shovel02.SetActive(true);
            Shovel01.SetActive(false);

            AnimComponent["DigAnim"].speed = -2;

            AnimComponent.Play("DigAnim");

            FillAnimWasPlayed = true;
        }

        if (DigAnimWasPlayed && !AnimComponent.IsPlaying("DigAnim"))
        {
            Shovel02.SetActive(false);
            Shovel01.SetActive(true);

            DigAnimWasPlayed = false;
        }

        if (FillAnimWasPlayed && !AnimComponent.IsPlaying("DigAnim"))
        {
            Shovel02.SetActive(false);
            Shovel01.SetActive(true);

            FillAnimWasPlayed = false;
        }

        if (PutShovelbackAnimWasPlayed && !AnimComponent.IsPlaying("PutShovelBack"))
        {
            Shovel02.SetActive(false);
            Shovel01.SetActive(false);

            PutShovelbackAnimWasPlayed = false;

            Guy.PuttingShovelOnBackEnded = true;
        }

        if (PutShovelbackAnimReverseWasPlayed && !AnimComponent.IsPlaying("PutShovelBack"))
        {

            Shovel02.SetActive(false);
            Shovel01.SetActive(true);

            foo = false;

            PutShovelbackAnimReverseWasPlayed = false;

            Guy.TakingShovelInHandsEnded = true;
        }
	}
}
