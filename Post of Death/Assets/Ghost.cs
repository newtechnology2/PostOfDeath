using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {
	public int GhostNums;
	public float AttackRidious;
	public Transform camera;
	public AudioSource GhostMusic;
	public int GhostOnAttack;
	public Transform GhostT;

	private Vector3[] Ghosts;
	private double AttackStart;

	// Use this for initialization
	void Start () {
		Ghosts = new Vector3[GhostNums];
		GhostOnAttack = -1;
		//GhostMusic.Play();
		Vector3 RandomMovement=Vector3.zero;
		for (int i=0; i<GhostNums; i++) {
			RandomMovement.x = (float)Random.Range (-500, 500);
			RandomMovement.z = (float)Random.Range (-500, 00);
			Ghosts [i]=RandomMovement;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 RandomMovement=Vector3.zero;

		for (int i=0; i<GhostNums; i++) {
			if (i != GhostOnAttack) {
				RandomMovement.x = (float)Random.Range (-1000, 1000)/100f;
				RandomMovement.z = (float)Random.Range (-1000, 1000)/100f;
				RandomMovement = Ghosts [i] + RandomMovement;
				RandomMovement.x%=500;
				RandomMovement.z%=500;
				Ghosts [i]=RandomMovement;
				RandomMovement=camera.position-RandomMovement;
				RandomMovement.y=0.0f;
				if (i==0)
					GhostT.localPosition = Ghosts [i];
				if (GhostOnAttack == -1&&RandomMovement.magnitude<AttackStart) {
					GhostOnAttack=i;
					AttackStart=Clock.GetTime().TotalSeconds;
					GhostMusic.Play();
				}
			}
			else{
				double PasstTime=Clock.GetTime().TotalSeconds-AttackStart;
				if (PasstTime>30)
					GhostOnAttack=-1;

			}
		}
	}
}
