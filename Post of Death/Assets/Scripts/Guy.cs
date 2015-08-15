using UnityEngine;
using System.Collections;

public class Guy : MonoBehaviour {

	public float Health;
	public float Stamina;
	public bool HasShovel;
	public static bool OnShovel;
	public static bool PuttingShovelOnBack;
	public static bool StartPuttingShovelOnBack;
	public static bool PuttingShovelOnBackEnded;
	public static bool TakingShovelInHands;
	public static bool StartTakingShovelInHands;
	public static bool TakingShovelInHandsEnded;

	// Use this for initialization
	void Start () {
		OnShovel=true;
		HasShovel=true;
	}
	
	// Update is called once per frame
	void Update () {
		if (OnShovel&&HasShovel) {
			Keys.KeyText = Keys.KeyText + '\n' + "Press ";
			Keys.KeyText = Keys.KeyText + Keys.ChangeToolActionKey.Key.ToString ();
			Keys.KeyText = Keys.KeyText + " to put shovel on back";
			Keys.KeyText = Keys.KeyText + '\n' + "Press ";
			Keys.KeyText = Keys.KeyText + Keys.DropActionKey.Key.ToString ();
			Keys.KeyText = Keys.KeyText + " to drop shovel";
			if (Keys.DropActionKey.pressed)
			{
				OnShovel=false;
				HasShovel=false;
			}
			if ((Keys.ChangeToolActionKey.pressed||StartPuttingShovelOnBack))
			{
				PuttingShovelOnBack=true;
				StartPuttingShovelOnBack=false;
				OnShovel=false;
			}
			if (PuttingShovelOnBackEnded)
			{
				PuttingShovelOnBackEnded=false;
				PuttingShovelOnBack=false;
			}
		}
		if (!OnShovel&&HasShovel&&!OnEnteringRiver.PlayerIsInRiver) {
			Keys.KeyText = Keys.KeyText + '\n' + "Press ";
			Keys.KeyText = Keys.KeyText + Keys.ChangeToolActionKey.Key.ToString ();
			Keys.KeyText = Keys.KeyText + " to take shovel in hands";
			if (Keys.ChangeToolActionKey.pressed||StartTakingShovelInHands)
			{
				TakingShovelInHands=true;
				StartTakingShovelInHands=false;
			}
			if (TakingShovelInHandsEnded)
			{
				TakingShovelInHandsEnded=false;
				TakingShovelInHands=false;
				OnShovel = true;
			}
		}
	}

}
