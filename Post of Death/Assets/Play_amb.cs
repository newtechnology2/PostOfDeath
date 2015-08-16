using UnityEngine;
using System.Collections;

public class Play_amb : MonoBehaviour {

	// Use this for initialization
	public  AudioSource Night;
	public  AudioSource Day;

	public void play_audio()
	{
		if (Clock.GetTime ().Hours >= 8 && Clock.GetTime ().Hours <= 20) {
			if(Day.isPlaying == false) 
			{
				Night.Stop();
				Day.Play();
			}
		}else if (Clock.GetTime ().Hours > 20 || Clock.GetTime ().Hours < 8) {
			if(Night.isPlaying == false) 
			{
				Day.Stop();
				Night.Play();
			}
		}
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		play_audio ();
		}
	
}

