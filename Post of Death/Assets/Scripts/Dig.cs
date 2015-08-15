using UnityEngine;
using System.Collections;

public class Dig : MonoBehaviour {

	public Transform CameraTransform;
	public Transform TheDig;

	public int UnwantedAraCount;
	public Transform UnwantedAra1Transform;
	public Transform UnwantedAra2Transform;
	public Transform UnwantedAra3Transform;
	public Transform UnwantedAra4Transform;
	public Transform UnwantedAra5Transform;
	public Transform UnwantedAra6Transform;
	public Transform UnwantedAra7Transform;
	public Transform UnwantedAra8Transform;
	public Transform UnwantedAra9Transform;
	public Transform UnwantedAra10Transform;
	public float UnwantedAra1Radius;
	public float UnwantedAra2Radius;
	public float UnwantedAra3Radius;
	public float UnwantedAra4Radius;
	public float UnwantedAra5Radius;
	public float UnwantedAra6Radius;
	public float UnwantedAra7Radius;
	public float UnwantedAra8Radius;
	public float UnwantedAra9Radius;
	public float UnwantedAra10Radius;

	public Terrain DiggingTerrain;

	private bool InUnwantedArea;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		InUnwantedArea=false;
		if (UnwantedAraCount >= 1)
		if ((CameraTransform.position - UnwantedAra1Transform.position).magnitude <= UnwantedAra1Radius) {
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 2)
		if ((CameraTransform.position-UnwantedAra2Transform.position).magnitude<=UnwantedAra2Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 3)
		if ((CameraTransform.position-UnwantedAra3Transform.position).magnitude<=UnwantedAra3Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 4)
		if ((CameraTransform.position-UnwantedAra4Transform.position).magnitude<=UnwantedAra4Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 5)
		if ((CameraTransform.position-UnwantedAra5Transform.position).magnitude<=UnwantedAra5Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 6)
		if ((CameraTransform.position-UnwantedAra6Transform.position).magnitude<=UnwantedAra6Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 7)
		if ((CameraTransform.position-UnwantedAra7Transform.position).magnitude<=UnwantedAra7Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 8)
		if ((CameraTransform.position-UnwantedAra8Transform.position).magnitude<=UnwantedAra8Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 9)
		if ((CameraTransform.position-UnwantedAra9Transform.position).magnitude<=UnwantedAra9Radius){
			InUnwantedArea=true;
		}
		if (UnwantedAraCount >= 10)
		if ((CameraTransform.position-UnwantedAra10Transform.position).magnitude<=UnwantedAra10Radius){
			InUnwantedArea=true;
		}
		if (Guy.OnShovel&&!InUnwantedArea)
		{
			Keys.KeyText = Keys.KeyText + '\n' + "Press ";
			Keys.KeyText = Keys.KeyText + Keys.PrimaryActionKey.Key.ToString ();
			Keys.KeyText = Keys.KeyText + " to dig";
			TheDig.position=CameraTransform.position;
			if(Keys.PrimaryActionKey.pressed)
			{
				Vector3 TerrainPosition =  DiggingTerrain.transform.position;
				float X = ((CameraTransform.position.x - TerrainPosition.x) / DiggingTerrain.terrainData.size.x) * DiggingTerrain.terrainData.alphamapWidth;
				float Z = ((CameraTransform.position.z - TerrainPosition.z) / DiggingTerrain.terrainData.size.z) * DiggingTerrain.terrainData.alphamapHeight;

				float PointHeight=0.5f;//DiggingTerrain.terrainData.GetInterpolatedHeight(X,Z)/*/DiggingTerrain.terrainData.size.y*/;
				float[,] heights;
				heights=new float[10,10];
				for (int i=0;i<10;i++)
					for(int j=0;j<10;j++)
						heights[i,j]=PointHeight;
				DiggingTerrain.terrainData.SetHeightsDelayLOD((int)X-5,(int)Z-5,heights);
				DiggingTerrain.ApplyDelayedHeightmapModification();
			}
		}
	}
}
