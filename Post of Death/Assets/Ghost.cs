using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {
	public int GhostNums;
	public float AttackRidious;
	public Transform camera;
	public AudioSource GhostMusic;
	public int GhostOnAttack;
	public Transform GhostT;

	private Transform[] Ghosts;
	private double AttackStart;

	// Use this for initialization
	void Start () {
		Ghosts=new Transform[5];
		GhostNums = 5;
		GhostOnAttack = -1;
		GhostMusic.Play();
	}
	
	// Update is called once per frame
	void Update () {
		GhostT = Ghosts [0];
		Vector3 RandomMovement=Vector3.zero;

		for (int i=0; i<GhostNums; i++) {
			if (i != GhostOnAttack) {
				RandomMovement.x = (float)Random.Range (-5, 5);
				RandomMovement.y = (float)Random.Range (-5, 5);
				RandomMovement = Ghosts [i].localPosition + RandomMovement;
				RandomMovement.x=Mathf.Clamp(RandomMovement.x,-255,255);
				RandomMovement.y=Mathf.Clamp(RandomMovement.y,-255,255);
				Ghosts [i].localPosition=RandomMovement;
				RandomMovement=camera.position-RandomMovement;
				RandomMovement.z=0.0f;
				if (GhostOnAttack == -1&&RandomMovement.magnitude<AttackStart) {
					GhostOnAttack=i;
					AttackStart=Clock.GetTime().Seconds;
					GhostMusic.Play();
				}
			}
			else{
				double PasstTime=Clock.GetTime().Seconds-AttackStart;
				if (PasstTime>30)
					GhostOnAttack=-1;

			}
		}
	}
}
