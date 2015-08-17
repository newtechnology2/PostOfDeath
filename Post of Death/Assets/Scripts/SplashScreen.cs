using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashScreen : MonoBehaviour 
{
    Transform[] AllObjects;

    Camera Cam;

    float TimeElapsed = 0;

    GameObject _ScriptsHolder;
    GameObject SplashScreenGO;
    GameObject Canvas;

    GameObject Play;
    GameObject Settings;
    GameObject Credits;
    GameObject Exit;

    GameObject EventSystem;

    public GameObject MenuCheckGO;
	public Texture secondtexture;

	public Texture texture1;
	public Texture texture2;
	public Texture texture3;
	public Texture texture4;

	void Start () 
    {

        DontDestroyOnLoad(MenuCheckGO);


        //Default resolution
        //Screen.SetResolution(1280, 720, false);

        AllObjects = GameObject.FindObjectsOfType(typeof(Transform)) as Transform[];
        Cam = FindObjectOfType<Camera>();

        Canvas = GameObject.Find("Canvas");

        Play = Canvas.transform.FindChild("Play").gameObject;
        Settings = Canvas.transform.FindChild("Settings").gameObject;
        Credits = Canvas.transform.FindChild("Credits").gameObject;
        Exit = Canvas.transform.FindChild("Exit").gameObject;


        EventSystem = GameObject.Find("EventSystem");

        SplashScreenGO = GameObject.Find("Canvas").transform.FindChild("SplashScreen").gameObject;

        _ScriptsHolder = GameObject.Find("_ScriptsHolder");

        for (int i = 0; i < AllObjects.Length; ++i)
        {
            AllObjects[i].gameObject.SetActive(false);
        }

        Cam.gameObject.SetActive(true);

        _ScriptsHolder.SetActive(true);

        SplashScreenGO.SetActive(true);

        Canvas.SetActive(true);

        EventSystem.SetActive(true);

        MenuCheckGO.SetActive(true);




        Cam.GetComponent<CameraRotation>().enabled = false;

         foreach (Transform child in SplashScreenGO.transform)
         {
             child.gameObject.SetActive(true);

             foreach (Transform child2 in child.transform)
             {
                 child2.gameObject.SetActive(true);
             }
         }

        
	}

    void Update()
    {
        TimeElapsed += Time.deltaTime;
		;
		if (TimeElapsed > 5.0f&&PlayerPrefs.GetInt("GuyLevel",0)!=6)
			SplashScreenGO.GetComponent<RawImage>().texture = secondtexture;
		if (TimeElapsed > 5.0f&&PlayerPrefs.GetInt("GuyLevel",0)==6)
			SplashScreenGO.GetComponent<RawImage>().texture = texture1;
		if (TimeElapsed > 10.0f&&PlayerPrefs.GetInt("GuyLevel",0)==6)
			SplashScreenGO.GetComponent<RawImage>().texture = texture2;
		if (TimeElapsed > 15.0f&&PlayerPrefs.GetInt("GuyLevel",0)==6)
			SplashScreenGO.GetComponent<RawImage>().texture = texture3;
		if (TimeElapsed > 20.0f&&PlayerPrefs.GetInt("GuyLevel",0)==6)
			SplashScreenGO.GetComponent<RawImage>().texture = texture4;
		if (TimeElapsed > 50.0f || MenuCheck.SplashScreenWasShown||(Input.GetKeyDown (KeyCode.Space)&&TimeElapsed >5.0))
        {

            Cam.GetComponent<CameraRotation>().enabled = true;

            Destroy(SplashScreenGO);

            Play.SetActive(true);
            Settings.SetActive(true);
            Credits.SetActive(true);
            Exit.SetActive(true);

            MenuCheck.SplashScreenWasShown = true;

            for (int i = 0; i < AllObjects.Length; ++i)
            {
                AllObjects[i].gameObject.SetActive(true);
            }

            //Destroy(this);
        }
    }
	
	public void Profile_StormyNature()
    {
        Application.OpenURL("http://www.gamedev.net/user/195613-stormynature/");
    }

    public void Profile_Slicer4ever()
    {
        Application.OpenURL("https://www.facebook.com/LiquidGames?_rdr=p");
    }

    public void Profile_FlamingDuck()
    {
        Application.OpenURL("http://www.gamedev.net/user/203442-theflamingskunk/");
    }

    public void Profile_SideEffectsSoftware()
    {
        Application.OpenURL("http://www.sidefx.com/index.php?option=com_content&task=view&id=1590&Itemid=337");
    }

    public void Profile_Lactose()
    {
        Application.OpenURL("http://www.gamedev.net/user/215134-lactose/");
    }
}
