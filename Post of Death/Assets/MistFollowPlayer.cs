using UnityEngine;
using System.Collections;

public class MistFollowPlayer : MonoBehaviour {

	private void update_position()
	{
		GameObject go = GameObject.Find ("Mist");
		Vector3 Mist_xyz = go.transform.position;
		Mist_xyz.x = gameObject.transform.position.x;
		Mist_xyz.y = gameObject.transform.position.y;
		Mist_xyz.z = gameObject.transform.position.z;

		go.transform.position = Mist_xyz;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		update_position();
	}
}
