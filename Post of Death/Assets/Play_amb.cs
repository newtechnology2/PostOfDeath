using UnityEngine;
using System.Collections;

public class Play_amb : MonoBehaviour {

	// Use this for initialization
	public  AudioSource Night;
	public  AudioSource Day;

	public void play_audio()
	{

	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Clock.GetTime ().Hours >= 8 || Clock.GetTime ().Hours <= 20) {
			if(Night.isPlaying == false)	
				Night.Play();
		}else if (Clock.GetTime ().Hours >= 20 || Clock.GetTime ().Hours <= 8) {
			if(Night.isPlaying == false)	
				Day.Play();
		}
	
	}
}
