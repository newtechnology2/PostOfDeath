using UnityEngine;
using System.Collections;

public class SleepFix : MonoBehaviour 
{

    public bool ShouldBeAbleToSleep = false;

    void Start()
    {
        ShouldBeAbleToSleep = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RigidBodyFPSController" && other.GetType() == typeof(CapsuleCollider))
        {
            ShouldBeAbleToSleep = true;
        }
        else
            ShouldBeAbleToSleep = false;

    }
}
