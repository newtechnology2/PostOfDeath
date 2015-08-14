using UnityEngine;
using System.Collections;

public class InfiniteTerrain : MonoBehaviour {

	public float x_min;
	public float x_max;
	public float z_min;
	public float z_max;
	public float x_cam_width;
	public float z_cam_width;

	private void loop_terrain()
	{
		if (gameObject.transform.position.x < x_min) 
		{
			Vector3 move_cam;
			move_cam = gameObject.transform.position;

			move_cam.x = x_max - x_cam_width;
			gameObject.transform.position = move_cam;
		}else if(gameObject.transform.position.x > x_max)
		{
			Vector3 move_cam;
			move_cam = gameObject.transform.position;
			
			move_cam.x = x_min + x_cam_width;		
			gameObject.transform.position = move_cam;
		}else if (gameObject.transform.position.z < z_min) 
		{
			Vector3 move_cam;
			move_cam = gameObject.transform.position;
			
			move_cam.z = z_max - z_cam_width;
			gameObject.transform.position = move_cam;
		}else if(gameObject.transform.position.z > z_max)
		{
			Vector3 move_cam;
			move_cam = gameObject.transform.position;
			
			move_cam.z = z_min + z_cam_width;	
			gameObject.transform.position = move_cam;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		loop_terrain ();
	}
}
