using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class EscapeMenu : MonoBehaviour 
{

    GameObject EscMenu;

    public GameObject ClockText;
    public GameObject KeyNames;
    public GameObject CannotSleepMsg;

    public AudioSource ButtonSound;

    RigidbodyFirstPersonController Controller;

    PlayerProperties PP;

    bool EnableMenu = false;

	void Start () 
    {


        if (PlayerPrefs.GetFloat("Clock", -99.0f) != -99.0f)
        {
            Clock.SetPastTime((double)PlayerPrefs.GetFloat("Clock"));
        }

        Debug.Log(PlayerPrefs.GetFloat("Clock"));

        
        EscMenu = GameObject.Find("Canvas").transform.FindChild("EscapeMenu").gameObject;
        EscMenu.SetActive(false);

        EnableMenu = false;

        Controller = FindObjectOfType<RigidbodyFirstPersonController>();
        PP = FindObjectOfType<PlayerProperties>();
	}

    public void PlayButtonSound()
    {
        ButtonSound.Play();
    }

    public void BacktoMenu()
    {
        PlayerPrefs.SetFloat("Health", PP.GetHealth());
        PlayerPrefs.SetFloat("Stamina", PP.GetStamina());

        PlayerPrefs.SetFloat("Clock", (float)Clock.GetTime().TotalHours);

        PlayerPrefs.Save();

        Application.LoadLevel("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EnableMenu = !EnableMenu;
        }

        if (EnableMenu)
        {
            ClockText.SetActive(false);
            KeyNames.SetActive(false);
            CannotSleepMsg.SetActive(false);

            Controller.enabled = false;

            EscMenu.SetActive(true);
        }
        else
        {
            ClockText.SetActive(true);
            KeyNames.SetActive(true);
            CannotSleepMsg.SetActive(true);

            Controller.enabled = true;

            EscMenu.SetActive(false);
        }
	}
}
