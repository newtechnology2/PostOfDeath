using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuBehaviour : MonoBehaviour 
{
    Transform Settings_SubMenu;
    Transform Credits_SubMenu;
    Transform Exit_SubMenu;

    InputField ScreenRes_X;
    InputField ScreenRes_Y;

    void Awake()
    {
        Settings_SubMenu = GameObject.Find("Canvas").transform.FindChild("Settings_SubMenu");
        Credits_SubMenu = GameObject.Find("Canvas").transform.FindChild("Credits_SubMenu");
        Exit_SubMenu = GameObject.Find("Canvas").transform.FindChild("Exit_SubMenu");


        ScreenRes_X = Settings_SubMenu.FindChild("ScreenRes_Width").gameObject.GetComponent<InputField>();
        ScreenRes_Y = Settings_SubMenu.FindChild("ScreenRes_Height").gameObject.GetComponent<InputField>();
    }

    public void EnableCredits_SubMenu()
    {
        Credits_SubMenu.gameObject.SetActive(true);
    }

    public void DisableCredits_SubMenu()
    {
        Credits_SubMenu.gameObject.SetActive(false);
    }

	public void EnableSetting_SubMenu()
    {
        Settings_SubMenu.gameObject.SetActive(true);
    }

    public void EnableExit_SubMenu()
    {
        Exit_SubMenu.gameObject.SetActive(true);
    }

    public void DisableExit_SubMenu()
    {
        Exit_SubMenu.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ChangeResolution()
    {
        int Width = 0;
        int Height = 0;

        bool FullScreen = Settings_SubMenu.FindChild("FullScreen").GetComponent<Toggle>().isOn;

        bool a = int.TryParse(ScreenRes_X.text, out Width);
        bool b = int.TryParse(ScreenRes_Y.text, out Height);

        //Minimum resolution is: 800x600
        if (a && Width < 800)
            a = false;

        if (b && Height < 600)
            b = false;

        if (a && b)
        {
            Screen.SetResolution(Width, Height, FullScreen);
        }
        else
        {
            Debug.LogError("Invalid input data.");

            if (!a)
                ScreenRes_X.text = "Invalid";
            if (!b)
                ScreenRes_Y.text = "Invalid";
        }
    }

    public void DisableSettings_SubMenu()
    {
        Settings_SubMenu.gameObject.SetActive(false);
    }
}
