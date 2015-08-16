using UnityEngine;
using System.Collections;

public class HintPlacer : MonoBehaviour {

	public static int Level;

	public Mesh MT1;
	public Mesh MT2;
	public Mesh MT3;
	public Mesh MT4;
	

	public Material MRT1L1;
	public Material MRT1L2;
	public Material MRT1L3;
	public Material MRT1L4;
	public Material MRT1L5;

	public Vector3 MT1Center;
	public Vector3 MT2Center;
	public Vector3 MT3Center;
	public Vector3 MT4Center;

	public Vector3 MT1Size;
	public Vector3 MT2Size;
	public Vector3 MT3Size;
	public Vector3 MT4Size;
	
	// Use this for initialization
	void Start () {
		Level=PlayerPrefs.GetInt("GuyLevel");
		if (Level == 0) {
			new GameObject ("HintGraveType1");
			GameObject.Find ("HintGraveType1").AddComponent<MeshFilter> ().mesh = MT1;
			GameObject.Find ("HintGraveType1").AddComponent<MeshRenderer> ().material = MRT1L1;
			GameObject.Find ("HintGraveType1").AddComponent<BoxCollider> ().center = MT1Center;
			GameObject.Find ("HintGraveType1").GetComponent<BoxCollider> ().size = MT1Size;

			new GameObject ("HintGraveType2");
			GameObject.Find ("HintGraveType2").AddComponent<MeshFilter> ().mesh = MT2;
			GameObject.Find ("HintGraveType2").AddComponent<MeshRenderer> ().material = MRT1L1;
			GameObject.Find ("HintGraveType2").AddComponent<BoxCollider> ().center = MT2Center;
			GameObject.Find ("HintGraveType2").GetComponent<BoxCollider> ().size = MT2Size;

			new GameObject ("HintGraveType3");
			GameObject.Find ("HintGraveType3").AddComponent<MeshFilter> ().mesh = MT3;
			GameObject.Find ("HintGraveType3").AddComponent<MeshRenderer> ().material = MRT1L1;
			GameObject.Find ("HintGraveType3").AddComponent<BoxCollider> ().center = MT3Center;
			GameObject.Find ("HintGraveType3").GetComponent<BoxCollider> ().size = MT3Size;

			new GameObject ("HintGraveType4");
			GameObject.Find ("HintGraveType4").AddComponent<MeshFilter> ().mesh = MT4;
			GameObject.Find ("HintGraveType4").AddComponent<MeshRenderer> ().material = MRT1L1;
			GameObject.Find ("HintGraveType4").AddComponent<BoxCollider> ().center = MT4Center;
			GameObject.Find ("HintGraveType4").GetComponent<BoxCollider> ().size = MT4Size;
		}
		if (Level == 1) {
			new GameObject ("HintGraveType1");
			GameObject.Find ("HintGraveType1").AddComponent<MeshFilter> ().mesh = MT1;
			GameObject.Find ("HintGraveType1").AddComponent<MeshRenderer> ().material = MRT1L2;
			GameObject.Find ("HintGraveType1").AddComponent<BoxCollider> ().center = MT1Center;
			GameObject.Find ("HintGraveType1").GetComponent<BoxCollider> ().size = MT1Size;
			
			new GameObject ("HintGraveType2");
			GameObject.Find ("HintGraveType2").AddComponent<MeshFilter> ().mesh = MT2;
			GameObject.Find ("HintGraveType2").AddComponent<MeshRenderer> ().material = MRT1L2;
			GameObject.Find ("HintGraveType2").AddComponent<BoxCollider> ().center = MT2Center;
			GameObject.Find ("HintGraveType2").GetComponent<BoxCollider> ().size = MT2Size;
			
			new GameObject ("HintGraveType3");
			GameObject.Find ("HintGraveType3").AddComponent<MeshFilter> ().mesh = MT3;
			GameObject.Find ("HintGraveType3").AddComponent<MeshRenderer> ().material = MRT1L2;
			GameObject.Find ("HintGraveType3").AddComponent<BoxCollider> ().center = MT3Center;
			GameObject.Find ("HintGraveType3").GetComponent<BoxCollider> ().size = MT3Size;
			
			new GameObject ("HintGraveType4");
			GameObject.Find ("HintGraveType4").AddComponent<MeshFilter> ().mesh = MT4;
			GameObject.Find ("HintGraveType4").AddComponent<MeshRenderer> ().material = MRT1L2;
			GameObject.Find ("HintGraveType4").AddComponent<BoxCollider> ().center = MT4Center;
			GameObject.Find ("HintGraveType4").GetComponent<BoxCollider> ().size = MT4Size;
		}
		if (Level == 2) {
			new GameObject ("HintGraveType1");
			GameObject.Find ("HintGraveType1").AddComponent<MeshFilter> ().mesh = MT1;
			GameObject.Find ("HintGraveType1").AddComponent<MeshRenderer> ().material = MRT1L3;
			GameObject.Find ("HintGraveType1").AddComponent<BoxCollider> ().center = MT1Center;
			GameObject.Find ("HintGraveType1").GetComponent<BoxCollider> ().size = MT1Size;
			
			new GameObject ("HintGraveType2");
			GameObject.Find ("HintGraveType2").AddComponent<MeshFilter> ().mesh = MT2;
			GameObject.Find ("HintGraveType2").AddComponent<MeshRenderer> ().material = MRT1L3;
			GameObject.Find ("HintGraveType2").AddComponent<BoxCollider> ().center = MT2Center;
			GameObject.Find ("HintGraveType2").GetComponent<BoxCollider> ().size = MT2Size;
			
			new GameObject ("HintGraveType3");
			GameObject.Find ("HintGraveType3").AddComponent<MeshFilter> ().mesh = MT3;
			GameObject.Find ("HintGraveType3").AddComponent<MeshRenderer> ().material = MRT1L3;
			GameObject.Find ("HintGraveType3").AddComponent<BoxCollider> ().center = MT3Center;
			GameObject.Find ("HintGraveType3").GetComponent<BoxCollider> ().size = MT3Size;
			
			new GameObject ("HintGraveType4");
			GameObject.Find ("HintGraveType4").AddComponent<MeshFilter> ().mesh = MT4;
			GameObject.Find ("HintGraveType4").AddComponent<MeshRenderer> ().material = MRT1L3;
			GameObject.Find ("HintGraveType4").AddComponent<BoxCollider> ().center = MT4Center;
			GameObject.Find ("HintGraveType4").GetComponent<BoxCollider> ().size = MT4Size;
		}
		if (Level == 3) {
			new GameObject ("HintGraveType1");
			GameObject.Find ("HintGraveType1").AddComponent<MeshFilter> ().mesh = MT1;
			GameObject.Find ("HintGraveType1").AddComponent<MeshRenderer> ().material = MRT1L4;
			GameObject.Find ("HintGraveType1").AddComponent<BoxCollider> ().center = MT1Center;
			GameObject.Find ("HintGraveType1").GetComponent<BoxCollider> ().size = MT1Size;
			
			new GameObject ("HintGraveType2");
			GameObject.Find ("HintGraveType2").AddComponent<MeshFilter> ().mesh = MT2;
			GameObject.Find ("HintGraveType2").AddComponent<MeshRenderer> ().material = MRT1L4;
			GameObject.Find ("HintGraveType2").AddComponent<BoxCollider> ().center = MT2Center;
			GameObject.Find ("HintGraveType2").GetComponent<BoxCollider> ().size = MT2Size;
			
			new GameObject ("HintGraveType3");
			GameObject.Find ("HintGraveType3").AddComponent<MeshFilter> ().mesh = MT3;
			GameObject.Find ("HintGraveType3").AddComponent<MeshRenderer> ().material = MRT1L4;
			GameObject.Find ("HintGraveType3").AddComponent<BoxCollider> ().center = MT3Center;
			GameObject.Find ("HintGraveType3").GetComponent<BoxCollider> ().size = MT3Size;
			
			new GameObject ("HintGraveType4");
			GameObject.Find ("HintGraveType4").AddComponent<MeshFilter> ().mesh = MT4;
			GameObject.Find ("HintGraveType4").AddComponent<MeshRenderer> ().material = MRT1L4;
			GameObject.Find ("HintGraveType4").AddComponent<BoxCollider> ().center = MT4Center;
			GameObject.Find ("HintGraveType4").GetComponent<BoxCollider> ().size = MT4Size;
		}
		if (Level == 4) {
			new GameObject ("HintGraveType1");
			GameObject.Find ("HintGraveType1").AddComponent<MeshFilter> ().mesh = MT1;
			GameObject.Find ("HintGraveType1").AddComponent<MeshRenderer> ().material = MRT1L5;
			GameObject.Find ("HintGraveType1").AddComponent<BoxCollider> ().center = MT1Center;
			GameObject.Find ("HintGraveType1").GetComponent<BoxCollider> ().size = MT1Size;
			
			new GameObject ("HintGraveType2");
			GameObject.Find ("HintGraveType2").AddComponent<MeshFilter> ().mesh = MT2;
			GameObject.Find ("HintGraveType2").AddComponent<MeshRenderer> ().material = MRT1L5;
			GameObject.Find ("HintGraveType2").AddComponent<BoxCollider> ().center = MT2Center;
			GameObject.Find ("HintGraveType2").GetComponent<BoxCollider> ().size = MT2Size;
			
			new GameObject ("HintGraveType3");
			GameObject.Find ("HintGraveType3").AddComponent<MeshFilter> ().mesh = MT3;
			GameObject.Find ("HintGraveType3").AddComponent<MeshRenderer> ().material = MRT1L5;
			GameObject.Find ("HintGraveType3").AddComponent<BoxCollider> ().center = MT3Center;
			GameObject.Find ("HintGraveType3").GetComponent<BoxCollider> ().size = MT3Size;
			
			new GameObject ("HintGraveType4");
			GameObject.Find ("HintGraveType4").AddComponent<MeshFilter> ().mesh = MT4;
			GameObject.Find ("HintGraveType4").AddComponent<MeshRenderer> ().material = MRT1L5;
			GameObject.Find ("HintGraveType4").AddComponent<BoxCollider> ().center = MT4Center;
			GameObject.Find ("HintGraveType4").GetComponent<BoxCollider> ().size = MT4Size;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
