using UnityEngine;
using System.Collections;

public class ShovelAnimation : MonoBehaviour 
{

    public GameObject Shovel01;
    public GameObject Shovel02;

	void Start () 
    {
        Shovel02.SetActive(false);
        Shovel01.SetActive(true);
	}
	
	
	void Update () 
    {
        //if (Guy.PlayDigAnim)
        {
            
        }
	}
}
