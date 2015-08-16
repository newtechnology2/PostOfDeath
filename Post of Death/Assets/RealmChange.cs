using UnityEngine;
using System.Collections;

public class RealmChange : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Body_col"&&!Timer.lost) {
			PlayerPrefs.SetInt("GuyLevel",HintPlacer.Level+1);
			Application.LoadLevel("PostOfDeath");
		}
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
