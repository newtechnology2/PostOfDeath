using UnityEngine;
using System.Collections;

public class MistFollowPlayer : MonoBehaviour {
	public float BoxSize;
	private void update_position()
	{
		Vector3 Mist_xyz = Vector3.zero;
		Mist_xyz.x = gameObject.transform.position.x;
		Mist_xyz.y = gameObject.transform.position.y;
		Mist_xyz.z = gameObject.transform.position.z;

		GameObject go = GameObject.Find ("Mist");
		go.transform.position = Mist_xyz+gameObject.transform.forward*BoxSize;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		update_position();
	}
}
