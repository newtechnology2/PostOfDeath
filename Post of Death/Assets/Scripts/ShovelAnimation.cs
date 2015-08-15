using UnityEngine;
using System.Collections;

public class ShovelAnimation : MonoBehaviour 
{

    public GameObject Shovel01;
    public GameObject Shovel02;

    Animation AnimComponent;

    bool DigAnimWasPlayed = false;
    bool FillAnimWasPlayed = false;
	void Start () 
    {
        Shovel02.SetActive(false);
        Shovel01.SetActive(true);

        AnimComponent = GetComponent<Animation>();

        DigAnimWasPlayed = false;
        FillAnimWasPlayed = false;

        PlayerPrefs.SetFloat("Stamina", 5.0f);
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
	}
}
