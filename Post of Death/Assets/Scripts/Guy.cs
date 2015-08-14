using UnityEngine;
using System.Collections;

public class Guy : MonoBehaviour {

	public float Health;
	public float Stamina;
	public bool HasShovel;
	public static bool OnShovel;

	// Use this for initialization
	void Start () {
		OnShovel = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
