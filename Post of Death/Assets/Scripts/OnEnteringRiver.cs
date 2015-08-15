using UnityEngine;
using System.Collections;

public class OnEnteringRiver : MonoBehaviour 
{

    GameObject PlayerBody;

    void Start()
    {
        PlayerBody = GameObject.Find("RigidBodyFPSController").transform.FindChild("MAX").gameObject;
    }

	void OnCollisionEnter(Collision collision)
    {
        PlayerBody.SetActive(false); 
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        PlayerBody.SetActive(true);
    }
}
