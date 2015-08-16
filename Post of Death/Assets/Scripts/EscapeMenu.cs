using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class EscapeMenu : MonoBehaviour 
{

    GameObject EscMenu;

    public GameObject GameOverText;
    public GameObject PlayAgainButton;

    public GameObject ClockText;
    public GameObject KeyNames;
    public GameObject CannotSleepMsg;

    public AudioSource ButtonSound;

    RigidbodyFirstPersonController Controller;

    PlayerProperties PP;


    Dig dig;

    public bool EnableMenu = false;
    public bool DisableInput = false;

    bool ControllerEnabled = false;

    void Awake()
    {
        dig = FindObjectOfType<Dig>();

        int Length = PlayerPrefs.GetInt("DataLength", 0);

        float[] Data = new float[Length];

        for (int i = 0; i < Length; ++i)
        {
            Data[i] = PlayerPrefs.GetFloat("Data" + i);
        }

        if (Length != 0)
            dig.SetDitchData(Data, Length);

    }
	void Start () 
    {

        if (PlayerPrefs.GetFloat("Clock", -99.0f) != -99.0f)
        {
             Debug.Log("Set!");
             Clock.SetPastTime((double)PlayerPrefs.GetFloat("Clock"));
        }

        
        EscMenu = GameObject.Find("Canvas").transform.FindChild("EscapeMenu").gameObject;
        EscMenu.SetActive(false);

        EnableMenu = false;
        ControllerEnabled = false;

        Controller = FindObjectOfType<RigidbodyFirstPersonController>();
        PP = FindObjectOfType<PlayerProperties>();

        DisableInput = false;
	}

    public void PlayAgain()
    {
        PlayerPrefs.DeleteAll();

        Application.LoadLevel(Application.loadedLevel);
    }

    public void PlayButtonSound()
    {
        ButtonSound.Play();
    }

    public void SaveStuff()
    {
        PlayerPrefs.SetFloat("Health", PP.GetHealth());
        PlayerPrefs.SetFloat("Stamina", PP.GetStamina());

        PlayerPrefs.SetFloat("Clock", (float)Clock.GetTime().TotalHours + (float)Clock.GetPastTime());

        float[] Data = dig.GetDitchData();

        for (int i = 0; i < Data.Length; ++i)
        {
            PlayerPrefs.SetFloat("Data" + i, Data[i]);
        }

        PlayerPrefs.SetInt("DataLength", Data.Length);


        PlayerPrefs.Save();
    }

    public void BacktoMenu()
    {

        SaveStuff();

        Application.LoadLevel("Menu");
    }

    public void Exit()
    {
        SaveStuff();

        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !DisableInput)
        {
            EnableMenu = !EnableMenu;
        }

        if (EnableMenu)
        {
            ControllerEnabled = false;

            if (!DisableInput)
            {
                GameOverText.SetActive(false);
                PlayAgainButton.SetActive(false);
            }
            
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

            if (!ControllerEnabled)
            {
                Controller.enabled = true;

                ControllerEnabled = true;
            }

            EscMenu.SetActive(false);
        }
	}
}
