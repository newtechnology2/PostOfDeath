using UnityEngine;
using System;
using System.Collections;

public class Ghost : MonoBehaviour {
	public int GhostNums;
	public float AttackRidious;
	public Transform camera;
	public AudioSource GhostMusic;
	public AudioSource GhostMusic2;
	public int GhostOnAttack;
	public Transform GhostT;

	public bool GhostAttacked;

	private Vector3[] Ghosts;
	private double AttackStart;
	private Vector3 GhostStartAttackPos;
	private PlayerProperties PP;
	
	// Use this for initialization
	void Start () {
		Ghosts = new Vector3[GhostNums];
		GhostOnAttack = -1;
		//GhostMusic.Play();
		Vector3 RandomMovement=Vector3.zero;
		for (int i=0; i<GhostNums; i++) {
			RandomMovement.x = (float)UnityEngine.Random.Range (-500, 500);
			RandomMovement.z = (float)UnityEngine.Random.Range (-500, 500);
			Ghosts [i]=RandomMovement;
		}
		PP = FindObjectOfType<PlayerProperties>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 RandomMovement=Vector3.zero;

		if (GhostOnAttack == -1)
			GhostAttacked=false;

		for (int i=0; i<GhostNums; i++) {
			if (i != GhostOnAttack) {
				RandomMovement.x = (float)UnityEngine.Random.Range (-1000, 1000)/100f;
				RandomMovement.z = (float)UnityEngine.Random.Range (-1000, 1000)/100f;
				RandomMovement = Ghosts [i] + RandomMovement;
				RandomMovement.x%=500;
				RandomMovement.z%=500;
				Ghosts [i]=RandomMovement;
				RandomMovement=camera.position-RandomMovement;
				RandomMovement.y=0.0f;
				if (GhostOnAttack == -1&&RandomMovement.magnitude<AttackRidious&&!Dig.InUnwantedArea) {
					GhostOnAttack=i;
					AttackStart=DateTime.Now.TimeOfDay.TotalSeconds;
					GhostMusic.Play();
					GhostMusic2.Play();
					GhostStartAttackPos=Ghosts [i];
				}
			}
			else{
				double PasstTime=DateTime.Now.TimeOfDay.TotalSeconds-AttackStart;
				Ghosts [i]=Vector3.Lerp (GhostStartAttackPos,camera.position,(float)PasstTime/21.0f);
				if ((float)PasstTime>21.0)
				{
					GhostOnAttack=-1;
					GhostAttacked=true;
					RandomMovement.x = (float)UnityEngine.Random.Range (-500, 500);
					RandomMovement.z = (float)UnityEngine.Random.Range (-500, 500);
					Ghosts [i]=RandomMovement;
					PP.SetHealth(Mathf.Clamp(PP.GetHealth()-2.5f,0,5f));
				}
				else
					GhostAttacked=false;
				GhostT.position = Ghosts [i];
			}
		}
	}
}

