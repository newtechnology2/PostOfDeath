using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Keys : MonoBehaviour {

	public static string KeyText;
	public Text KeyMessage;

	public class PrimaryActionKey
	{
		public static KeyCode Key;
		public static bool pressed;
		public static string KeyName;
	}

    public class SleepActionKey
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
	public class PickActionKey
	{
		public static KeyCode Key;
		public static bool pressed;
		public static string KeyName;
	}
	public class DropActionKey
	{
		public static KeyCode Key;
		public static bool pressed;
		public static string KeyName;
	}
	public class ChangeToolActionKey
	{
		public static KeyCode Key;
		public static bool pressed;
		public static string KeyName;
	}

	// Use this for initialization
	void Start () {
		PrimaryActionKey.Key = KeyCode.F;
		PrimaryActionKey.KeyName = "Primery Action";

        SleepActionKey.Key = KeyCode.U;
        SleepActionKey.KeyName = "Sleep Action";

		SecondaryActionKey.Key = KeyCode.H;
		SecondaryActionKey.KeyName = "Secondary Action";

		PickActionKey.Key = KeyCode.E;
		PickActionKey.KeyName = "Pick Action";
		
		DropActionKey.Key = KeyCode.G;
		DropActionKey.KeyName = "Drop Action";

		ChangeToolActionKey.Key = KeyCode.Q;
		ChangeToolActionKey.KeyName = "Change Tool Action";
		
	}
	
	// Update is called once per frame
	void Update () {
		KeyMessage.text = KeyText;
		KeyText = "";
		PrimaryActionKey.pressed = Input.GetKeyDown (PrimaryActionKey.Key);
		SecondaryActionKey.pressed = Input.GetKeyDown (SecondaryActionKey.Key);
		PickActionKey.pressed = Input.GetKeyDown (PickActionKey.Key);
		DropActionKey.pressed = Input.GetKeyDown (DropActionKey.Key);
		ChangeToolActionKey.pressed = Input.GetKeyDown (ChangeToolActionKey.Key);
        SleepActionKey.pressed = Input.GetKeyDown(SleepActionKey.Key);
	}
}
