using UnityEngine;
using System.Collections;

public class Keys : MonoBehaviour {

	public class PrimaryActionKey
	{
		public static KeyCode Key;
		public static bool pressed;
		public static string KeyName;
	}
	public class SecondaryActionKey
	{
		public static KeyCode Key;
		public static bool pressed;
		public static string KeyName;
	}

	// Use this for initialization
	void Start () {
		PrimaryActionKey.Key = KeyCode.F;
		PrimaryActionKey.KeyName = "Primery Action";

		SecondaryActionKey.Key = KeyCode.H;
		SecondaryActionKey.KeyName = "Secondary Action";

	}
	
	// Update is called once per frame
	void Update () {
		PrimaryActionKey.pressed = Input.GetKeyDown (PrimaryActionKey.Key);
		SecondaryActionKey.pressed = Input.GetKeyDown (SecondaryActionKey.Key);
	}
}
