using UnityEngine;
using System.Collections;

public class OnEnteringRiver : MonoBehaviour 
{

    GameObject PlayerBody;

    public static bool PlayerIsInRiver;

    void Start()
    {
        PlayerBody = GameObject.Find("RigidBodyFPSController").transform.FindChild("MAX").gameObject;

        PlayerIsInRiver = false;
    }

	void OnCollisionEnter(Collision collision)
    {
        PlayerBody.SetActive(false);

        PlayerIsInRiver = true;
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        PlayerBody.SetActive(true);

        PlayerIsInRiver = false;
    }
}
