using UnityEngine;
using System.Collections;

public class HintPlacer : MonoBehaviour {

	public Transform BodyT;
	public Transform CameraT;
	public float Distance;

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

	public Transform Light1;
	public Transform Light2;
	public Transform Light3;
	public Transform Light4;
	public Transform Light5;
	public Transform Light6;
	public Transform Light7;
	public Transform Light8;	
	
	// Use this for initialization
	void Start () {

		Vector3 RandPos = Vector3.zero;
		RandPos.x = Random.Range (-100, 100);
		RandPos.z = Random.Range (-100, 100);
		Vector3 direction;
		direction = RandPos / RandPos.magnitude * Distance;
		RandPos =  direction + CameraT.position;
		RandPos.y = 0.5f;
		BodyT.position = RandPos;


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
		Vector3 temp = direction / 5 + CameraT.position;
		temp.y = 0;
		temp.x += Random.Range (-1, 1);
		temp.z += Random.Range (-1, 1);
		GameObject.Find ("HintGraveType1").GetComponent<Transform> ().position = temp;
		temp.y = 1;
		temp.z =temp.z + 1;
		Light1.position = temp;
		temp.z =temp.z - 2;
		Light2.position = temp;

		temp = direction / 5 * 2 + CameraT.position;
		temp.y = 0;
		temp.x += Random.Range (-1, 1);
		temp.z += Random.Range (-1, 1);
		GameObject.Find ("HintGraveType2").GetComponent<Transform> ().position = temp;
		temp.y = 1;
		temp.z =temp.z + 1;
		Light3.position = temp;
		temp.z =temp.z - 2;
		Light4.position = temp;

		temp = direction / 5 * 3 + CameraT.position;
		temp.y = 0;
		temp.x += Random.Range (-1, 1);
		temp.z += Random.Range (-1, 1);
		GameObject.Find ("HintGraveType3").GetComponent<Transform> ().position = temp;
		temp.y = 1;
		temp.z =temp.z + 1;
		Light5.position = temp;
		temp.z =temp.z - 2;
		Light6.position = temp;

		temp = direction / 5 * 4 + CameraT.position;
		temp.y = 0;
		temp.x += Random.Range (-1, 1);
		temp.z += Random.Range (-1, 1);
		GameObject.Find ("HintGraveType4").GetComponent<Transform> ().position = temp;
		temp.y = 1;
		temp.z =temp.z + 1;
		Light7.position = temp;
		temp.z =temp.z - 2;
		Light8.position = temp;


		direction.x = 270;
		direction.y = 0;
		direction.z = 0;

		GameObject.Find ("HintGraveType1").GetComponent<Transform> ().rotation = Quaternion.Euler(direction);
		GameObject.Find ("HintGraveType2").GetComponent<Transform> ().rotation = Quaternion.Euler(direction);
		GameObject.Find ("HintGraveType3").GetComponent<Transform> ().rotation = Quaternion.Euler(direction);
		GameObject.Find ("HintGraveType4").GetComponent<Transform> ().rotation = Quaternion.Euler(direction);
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
