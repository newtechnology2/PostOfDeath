using UnityEngine;
using System.Collections;

public class OnEnteringRiver : MonoBehaviour 
{

    GameObject PlayerBody;

    public static bool PlayerIsInRiver;

    void Start()
    {
        PlayerBody = GameObject.Find("RigidBodyFPSController").transform.FindChild("Body").FindChild("MAX").gameObject;

        PlayerIsInRiver = false;
    }

	void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered river.");

        PlayerBody.SetActive(false);

        PlayerIsInRiver = true;
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        Debug.Log("Out of river.");
        PlayerBody.SetActive(true);

        PlayerIsInRiver = false;
    }
}
