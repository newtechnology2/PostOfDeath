using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour 
{

	
	void FixedUpdate () 
    {
        float Angle = Mathf.Deg2Rad * 5.0f; 

       
        gameObject.transform.Rotate(0.0f, Angle, 0.0f);

        if (Angle >= Mathf.Deg2Rad * 360)
            Angle = 0;
	}
}
