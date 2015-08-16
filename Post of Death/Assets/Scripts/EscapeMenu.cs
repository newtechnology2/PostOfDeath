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
    public Transform PlayerPosition;

    public AudioSource ButtonSound;

    RigidbodyFirstPersonController Controller;

    PlayerProperties PP;

    Clock clock;

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
        clock = GameObject.Find("Texts").transform.FindChild("Canvas").FindChild("Clock").GetComponent<Clock>();

        float x = PlayerPrefs.GetFloat("PosX", 0.0f);
        float y = PlayerPrefs.GetFloat("PosY", 0.0f);
        float z = PlayerPrefs.GetFloat("PosZ", 0.0f);

        if (!(x == 0 && y == 0 && z == 0))
        {
            PlayerPosition.position = new Vector3(x, y, z);
        }

        if (PlayerPrefs.GetInt("MovedToOtherWorld", 0) == 0)
            Dig.MovedToOtherWorld = false;
        else
            Dig.MovedToOtherWorld = true;


        Guy.Level = PlayerPrefs.GetInt("GuyLevel", 0);

        if (PlayerPrefs.GetInt("InTheDitch", 0) == 0)
            Dig.InTheDitch = false;
        else if (PlayerPrefs.GetInt("InTheDitch", 0) == 1)
            Dig.InTheDitch = true;

        if (PlayerPrefs.GetFloat("Clock", -99.0f) != -99.0f)
        {
             Debug.Log("Set!");
             Debug.Log("Time: " + PlayerPrefs.GetFloat("Clock"));

             clock.SetPastTime((double)PlayerPrefs.GetFloat("Clock"));
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

        PlayerPrefs.SetFloat("PosX", PlayerPosition.position.x);
        PlayerPrefs.SetFloat("PosY", PlayerPosition.position.y);
        PlayerPrefs.SetFloat("PosZ", PlayerPosition.position.z);

        PlayerPrefs.SetInt("GuyLevel", Guy.Level);

        if (Dig.InTheDitch == true)
            PlayerPrefs.SetInt("InTheDitch", 1);
        else
            PlayerPrefs.SetInt("InTheDitch", 0);

        if (Dig.MovedToOtherWorld == true)
            PlayerPrefs.SetInt("MovedToOtherWorld", 1);
        else
            PlayerPrefs.SetInt("MovedToOtherWorld", 0);
      
        PlayerPrefs.SetFloat("Clock", (float)Clock.GetTime().TotalHours + (float)clock.GetPastTime());

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

        if (GameOverText.activeInHierarchy)
            PlayerPrefs.DeleteAll();
        else
            SaveStuff();

        Application.LoadLevel("Menu");
    }

    public void Exit()
    {
        if (GameOverText.activeInHierarchy)
            PlayerPrefs.DeleteAll();
        else
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
