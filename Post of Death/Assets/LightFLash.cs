using UnityEngine;
using System.Collections;

public class LightFLash : MonoBehaviour {

	// Use this for initialization
	public float distance_start;
	public CanvasGroup flash_canvas; 

	public void change_alpha()
	{
		float alpha = flash_canvas.alpha;
		GameObject go = GameObject.Find ("Body");
		float distance = (go.transform.position-gameObject.transform.position).magnitude;
		alpha = ( Mathf.Clamp((distance_start-distance),0,distance_start)/distance_start );

		flash_canvas.alpha = alpha;
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		change_alpha ();
	}
}
