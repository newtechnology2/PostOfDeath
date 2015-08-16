using UnityEngine;
using System.Collections;

public class BodyPlacer : MonoBehaviour {

	public Transform BodyT;
	public Transform CameraT;
	public float Distance;
	// Use this for initialization
	void Start () {
		Vector3 RandPos = Vector3.zero;
		RandPos.x = Random.Range (-100, 100);
		RandPos.z = Random.Range (-100, 100);
		RandPos = RandPos / RandPos.magnitude * Distance + CameraT.position;
		RandPos.y = 0;
		BodyT.position = RandPos;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
