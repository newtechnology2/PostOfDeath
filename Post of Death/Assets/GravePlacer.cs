using UnityEngine;
using System.Collections;

public class GravePlacer : MonoBehaviour {
	public int MapMinX;
	public int MapMaxX;
	public int MapMinZ;
	public int MapMaxZ;

	public float Y;

	public int GraveType1Counts;
	public int GraveType2Counts;
	public int GraveType3Counts;
	public int GraveType4Counts;
	public int GraveType5Counts;
	public int GraveType6Counts;
	public int GraveType7Counts;
	public int GraveType8Counts;
	public int GraveType9Counts;
	
	public Mesh GraveType1Mesh;
	public Mesh GraveType2Mesh;
	public Mesh GraveType3Mesh;
	public Mesh GraveType4Mesh;
	public Mesh GraveType5Mesh;
	public Mesh GraveType6Mesh;
	public Mesh GraveType7Mesh;
	public Mesh GraveType8Mesh;
	public Mesh GraveType9Mesh;

	public Material GravesType1Material;
	public Material GravesType2Material;
	public Material GravesType3Material;
	public Material GravesType4Material;
	public Material GravesType5Material;
	public Material GravesType6Material;
	public Material GravesType7Material;
	public Material GravesType8Material;
	public Material GravesType9Material;

	public Vector3 GraveType1Roation;
	public Vector3 GraveType2Roation;
	public Vector3 GraveType3Roation;
	public Vector3 GraveType4Roation;
	public Vector3 GraveType5Roation;
	public Vector3 GraveType6Roation;
	public Vector3 GraveType7Roation;
	public Vector3 GraveType8Roation;
	public Vector3 GraveType9Roation;

	public Vector3 GraveType1ColliderBoxCenter;
	public Vector3 GraveType2ColliderBoxCenter;
	public Vector3 GraveType3ColliderBoxCenter;
	public Vector3 GraveType4ColliderBoxCenter;
	public Vector3 GraveType5ColliderBoxCenter;
	public Vector3 GraveType6ColliderBoxCenter;
	public Vector3 GraveType7ColliderBoxCenter;
	public Vector3 GraveType8ColliderBoxCenter;
	public Vector3 GraveType9ColliderBoxCenter;

	public Vector3 GraveType1ColliderBoxSize;
	public Vector3 GraveType2ColliderBoxSize;
	public Vector3 GraveType3ColliderBoxSize;
	public Vector3 GraveType4ColliderBoxSize;
	public Vector3 GraveType5ColliderBoxSize;
	public Vector3 GraveType6ColliderBoxSize;
	public Vector3 GraveType7ColliderBoxSize;
	public Vector3 GraveType8ColliderBoxSize;
	public Vector3 GraveType9ColliderBoxSize;

	public bool PlaceGraves;

	// Use this for initialization
	void Start () {
		for (int i=0; i<GraveType1Counts; i++) {
			new GameObject ("GraveType1Num" + i);
			GameObject.Find("GraveType1Num" + i).AddComponent<MeshFilter>().mesh=GraveType1Mesh;
			GameObject.Find("GraveType1Num" + i).AddComponent<MeshRenderer>().material=GravesType1Material;
			GameObject.Find("GraveType1Num" + i).AddComponent<BoxCollider>().center=GraveType1ColliderBoxCenter;
			GameObject.Find("GraveType1Num" + i).GetComponent<BoxCollider>().size=GraveType1ColliderBoxSize;
		}
		for (int i=0; i<GraveType2Counts; i++) {
			new GameObject ("GraveType2Num" + i);
			GameObject.Find("GraveType2Num" + i).AddComponent<MeshFilter>().mesh=GraveType2Mesh;
			GameObject.Find("GraveType2Num" + i).AddComponent<MeshRenderer>().material=GravesType2Material;
			GameObject.Find("GraveType2Num" + i).AddComponent<BoxCollider>().center=GraveType2ColliderBoxCenter;
			GameObject.Find("GraveType2Num" + i).GetComponent<BoxCollider>().size=GraveType2ColliderBoxSize;
		}
		for (int i=0; i<GraveType3Counts; i++) {
			new GameObject ("GraveType3Num" + i);
			GameObject.Find("GraveType3Num" + i).AddComponent<MeshFilter>().mesh=GraveType3Mesh;
			GameObject.Find("GraveType3Num" + i).AddComponent<MeshRenderer>().material=GravesType3Material;
			GameObject.Find("GraveType3Num" + i).AddComponent<BoxCollider>().center=GraveType3ColliderBoxCenter;
			GameObject.Find("GraveType3Num" + i).GetComponent<BoxCollider>().size=GraveType3ColliderBoxSize;
		}
		for (int i=0; i<GraveType4Counts; i++) {
			new GameObject ("GraveType4Num" + i);
			GameObject.Find("GraveType4Num" + i).AddComponent<MeshFilter>().mesh=GraveType4Mesh;
			GameObject.Find("GraveType4Num" + i).AddComponent<MeshRenderer>().material=GravesType4Material;
			GameObject.Find("GraveType4Num" + i).AddComponent<BoxCollider>().center=GraveType4ColliderBoxCenter;
			GameObject.Find("GraveType4Num" + i).GetComponent<BoxCollider>().size=GraveType4ColliderBoxSize;
		}
		for (int i=0; i<GraveType5Counts; i++) {
			new GameObject ("GraveType5Num" + i);
			GameObject.Find("GraveType5Num" + i).AddComponent<MeshFilter>().mesh=GraveType5Mesh;
			GameObject.Find("GraveType5Num" + i).AddComponent<MeshRenderer>().material=GravesType5Material;
			GameObject.Find("GraveType5Num" + i).AddComponent<BoxCollider>().center=GraveType5ColliderBoxCenter;
			GameObject.Find("GraveType5Num" + i).GetComponent<BoxCollider>().size=GraveType5ColliderBoxSize;
		}
		for (int i=0; i<GraveType6Counts; i++) {
			new GameObject ("GraveType6Num" + i);
			GameObject.Find("GraveType6Num" + i).AddComponent<MeshFilter>().mesh=GraveType6Mesh;
			GameObject.Find("GraveType6Num" + i).AddComponent<MeshRenderer>().material=GravesType6Material;
			GameObject.Find("GraveType6Num" + i).AddComponent<BoxCollider>().center=GraveType6ColliderBoxCenter;
			GameObject.Find("GraveType6Num" + i).GetComponent<BoxCollider>().size=GraveType6ColliderBoxSize;
		}
		for (int i=0; i<GraveType7Counts; i++) {
			new GameObject ("GraveType7Num" + i);
			GameObject.Find("GraveType7Num" + i).AddComponent<MeshFilter>().mesh=GraveType7Mesh;
			GameObject.Find("GraveType7Num" + i).AddComponent<MeshRenderer>().material=GravesType7Material;
			GameObject.Find("GraveType7Num" + i).AddComponent<BoxCollider>().center=GraveType7ColliderBoxCenter;
			GameObject.Find("GraveType7Num" + i).GetComponent<BoxCollider>().size=GraveType7ColliderBoxSize;
		}
		for (int i=0; i<GraveType8Counts; i++) {
			new GameObject ("GraveType8Num" + i);
			GameObject.Find("GraveType8Num" + i).AddComponent<MeshFilter>().mesh=GraveType8Mesh;
			GameObject.Find("GraveType8Num" + i).AddComponent<MeshRenderer>().material=GravesType8Material;
			GameObject.Find("GraveType8Num" + i).AddComponent<BoxCollider>().center=GraveType8ColliderBoxCenter;
			GameObject.Find("GraveType8Num" + i).GetComponent<BoxCollider>().size=GraveType8ColliderBoxSize;
		}
		for (int i=0; i<GraveType9Counts; i++) {
			new GameObject ("GraveType9Num" + i);
			GameObject.Find("GraveType9Num" + i).AddComponent<MeshFilter>().mesh=GraveType9Mesh;
			GameObject.Find("GraveType9Num" + i).AddComponent<MeshRenderer>().material=GravesType9Material;
			GameObject.Find("GraveType9Num" + i).AddComponent<BoxCollider>().center=GraveType9ColliderBoxCenter;
			GameObject.Find("GraveType9Num" + i).GetComponent<BoxCollider>().size=GraveType9ColliderBoxSize;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlaceGraves)
		{
			Vector3 randompos;
			randompos.y=Y;
			for (int i=0; i<GraveType1Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType1Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType1Roation);
				GameObject.Find("GraveType1Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType2Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType2Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType2Roation);
				GameObject.Find("GraveType2Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType3Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType3Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType3Roation);
				GameObject.Find("GraveType3Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType4Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType4Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType4Roation);
				GameObject.Find("GraveType4Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType5Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType5Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType5Roation);
				GameObject.Find("GraveType5Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType6Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType6Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType6Roation);
				GameObject.Find("GraveType6Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType7Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType7Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType7Roation);
				GameObject.Find("GraveType7Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType8Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType8Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType8Roation);
				GameObject.Find("GraveType8Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			for (int i=0; i<GraveType9Counts; i++)
			{
				randompos.x=(float)Random.Range(MapMinX,MapMaxX);
				randompos.z=(float)Random.Range(MapMinZ,MapMaxZ);
				GameObject.Find("GraveType9Num" + i).GetComponent<Transform>().localRotation=Quaternion.Euler(GraveType9Roation);
				GameObject.Find("GraveType9Num" + i).GetComponent<Transform>().localPosition=randompos;
			}
			PlaceGraves = false;
		}
	}
}
