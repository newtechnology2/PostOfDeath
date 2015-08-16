using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Dig : MonoBehaviour {
	public Text StaminaFail;

	public static bool LayDownInTheDitch;
	public static bool InTheDitch;
	public static bool GetOutTheDitch;
	public static bool PlayTheDigAnim;
	public static bool PlayTheFillAnim;

	public Transform CameraTransform;
	public Transform TheDig;
	public int NearByDitchID;

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
	private int DitchesCount;

	public static Vector3[] Ditches;

	private PlayerProperties PP;
	private bool ClearText;
	private double Seconds;
	private double Seconds2;
	// Use this for initialization
	void Start () {
		NearByDitchID = -1;
		DitchesCount = 0;
		PP = FindObjectOfType<PlayerProperties>();
		PP.SetHealth (5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		PlayTheDigAnim = false;
		PlayTheFillAnim = false;

		if (ClearText && DateTime.Now.TimeOfDay.TotalSeconds - Seconds > 5.0) {
			ClearText = false;
			StaminaFail.text = "";
		}

		InUnwantedArea = false;
		if (UnwantedAraCount >= 1)
		if ((CameraTransform.position - UnwantedAra1Transform.position).magnitude <= UnwantedAra1Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 2)
		if ((CameraTransform.position - UnwantedAra2Transform.position).magnitude <= UnwantedAra2Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 3)
		if ((CameraTransform.position - UnwantedAra3Transform.position).magnitude <= UnwantedAra3Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 4)
		if ((CameraTransform.position - UnwantedAra4Transform.position).magnitude <= UnwantedAra4Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 5)
		if ((CameraTransform.position - UnwantedAra5Transform.position).magnitude <= UnwantedAra5Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 6)
		if ((CameraTransform.position - UnwantedAra6Transform.position).magnitude <= UnwantedAra6Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 7)
		if ((CameraTransform.position - UnwantedAra7Transform.position).magnitude <= UnwantedAra7Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 8)
		if ((CameraTransform.position - UnwantedAra8Transform.position).magnitude <= UnwantedAra8Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 9)
		if ((CameraTransform.position - UnwantedAra9Transform.position).magnitude <= UnwantedAra9Radius) {
			InUnwantedArea = true;
		}
		if (UnwantedAraCount >= 10)
		if ((CameraTransform.position - UnwantedAra10Transform.position).magnitude <= UnwantedAra10Radius) {
			InUnwantedArea = true;
		}
		Vector3 TerrainPosition = DiggingTerrain.transform.position;
		float X = ((CameraTransform.position.x - TerrainPosition.x) / DiggingTerrain.terrainData.size.x) * DiggingTerrain.terrainData.alphamapWidth;
		float Z = ((CameraTransform.position.z - TerrainPosition.z) / DiggingTerrain.terrainData.size.z) * DiggingTerrain.terrainData.alphamapHeight;
		NearByDitchID = -1;
		for (int i=0; i<DitchesCount; i++)
			if (Mathf.Abs ((int)Ditches [i].x - X) < 4 && Mathf.Abs ((int)Ditches [i].z - Z) < 4) {
				NearByDitchID = i;
				break;
			}
		if (NearByDitchID != -1) {
			if (!InTheDitch) {
				Keys.KeyText = Keys.KeyText + '\n' + "Press ";
				Keys.KeyText = Keys.KeyText + Keys.PrimaryActionKey.Key.ToString ();
				Keys.KeyText = Keys.KeyText + " to lay down in the ditch";
				GetOutTheDitch = false;
				LayDownInTheDitch = Keys.PrimaryActionKey.pressed;
				if (LayDownInTheDitch)
					InTheDitch = true;
			} else {
				Keys.KeyText = Keys.KeyText + '\n' + "Press ";
				Keys.KeyText = Keys.KeyText + Keys.PrimaryActionKey.Key.ToString ();
				Keys.KeyText = Keys.KeyText + " to get out of the ditch";
				LayDownInTheDitch = false;
				GetOutTheDitch = Keys.PrimaryActionKey.pressed;
				if (GetOutTheDitch)
					InTheDitch = false;
			}
		}
		if (Guy.OnShovel&&NearByDitchID != -1) {
			if(!InTheDitch)
			{
				Keys.KeyText = Keys.KeyText + '\n' + "Press ";
				Keys.KeyText = Keys.KeyText + Keys.SecondaryActionKey.Key.ToString ();
				Keys.KeyText = Keys.KeyText + " to fill the ditch";
				
				if (Keys.SecondaryActionKey.pressed)
				{
					if (PP.GetStamina()+10.0f>1.0f)
					{
						float[,] heights;
						heights=new float[6,6];
						
						heights=DiggingTerrain.terrainData.GetHeights((int)Ditches[NearByDitchID].x-3,(int)Ditches[NearByDitchID].z-3,6,6);
						
						for (int i=0;i<6;i++)
							for(int j=0;j<3;j++)
								heights[i,j]-=(-(((float)j-1.5f)*((float)j-1.5f)/2.25f+((float)i-2.5f)*((float)i-2.5f)/6.25f)+2)/DiggingTerrain.terrainData.size.y;
						for (int i=1;i<5;i++)
							for(int j=4;j<6;j++)
								heights[i,j]+=2.0f/DiggingTerrain.terrainData.size.y;
						DiggingTerrain.terrainData.SetHeightsDelayLOD((int)Ditches[NearByDitchID].x-3,(int)Ditches[NearByDitchID].z-3,heights);
						DiggingTerrain.ApplyDelayedHeightmapModification();
						Vector3[] tempDitches=new Vector3[DitchesCount];
						for (int i=0;i<DitchesCount;i++)
							tempDitches[i]=Ditches[i];
						DitchesCount--;
						Ditches=new Vector3[DitchesCount];
						for (int i=0;i<DitchesCount;i++)
							if(i<NearByDitchID)
								Ditches[i]=tempDitches[i];
						else
							Ditches[i]=tempDitches[i+1];
						
						PP.SetStamina(PP.GetStamina()-1.0f);
						PlayTheFillAnim=true;
					}
					else{
						ClearText=true;
						Seconds=DateTime.Now.TimeOfDay.Seconds;
						StaminaFail.text="You're too tired to fill the dig";
					}
				}
			}
		}
		if (Guy.OnShovel&&!InUnwantedArea&&NearByDitchID==-1)
		{
			Keys.KeyText = Keys.KeyText + '\n' + "Press ";
			Keys.KeyText = Keys.KeyText + Keys.PrimaryActionKey.Key.ToString ();
			Keys.KeyText = Keys.KeyText + " to dig";
			TheDig.position=CameraTransform.position;
			if(Keys.PrimaryActionKey.pressed)
			{
				if (PP.GetStamina()+10.0f>2.5f)
				{
					Vector3[] tempDitches=new Vector3[DitchesCount];
					
					for (int i=0;i<DitchesCount;i++)
						tempDitches[i]=Ditches[i];
					
					DitchesCount++;
					Ditches=new Vector3[DitchesCount];
					
					for (int i=0;i<DitchesCount-1;i++)
						Ditches[i]=tempDitches[i];
					Ditches[DitchesCount-1].x=X;
					Ditches[DitchesCount-1].z=Z;
					float[,] heights;
					heights=new float[6,6];
					
					heights=DiggingTerrain.terrainData.GetHeights((int)X-3,(int)Z-3,6,6);
					
					for (int i=0;i<6;i++)
						for(int j=0;j<3;j++)
							heights[i,j]+=(-(((float)j-1.5f)*((float)j-1.5f)/2.25f+((float)i-2.5f)*((float)i-2.5f)/6.25f)+2)/DiggingTerrain.terrainData.size.y;
					for (int i=1;i<5;i++)
						for(int j=4;j<6;j++)
							heights[i,j]-=2.0f/DiggingTerrain.terrainData.size.y;
					DiggingTerrain.terrainData.SetHeightsDelayLOD((int)X-3,(int)Z-3,heights);
					DiggingTerrain.ApplyDelayedHeightmapModification();
					float[,,] alphamaps;
					alphamaps=new float[6,7,13];
					for (int i=0;i<6;i++)
						for(int j=0;j<7;j++)
							alphamaps[i,j,7]=1f;
					DiggingTerrain.terrainData.SetAlphamaps((int)X-4,(int)Z-4,alphamaps);
					int[,] DetailDens;
					DetailDens = DiggingTerrain.terrainData.GetDetailLayer((int)X-3,(int)Z-3,6,6,0);
					
					for (int i=0;i<6;i++)
						for(int j=0;j<6;j++)
							DetailDens[i,j]=0;
					DiggingTerrain.terrainData.SetDetailLayer((int)X-3,(int)Z-3, 0, DetailDens); 
					DetailDens = DiggingTerrain.terrainData.GetDetailLayer((int)X-3,(int)Z-3,6,6,1);
					
					for (int i=0;i<6;i++)
						for(int j=0;j<6;j++)
							DetailDens[i,j]=0;
					DiggingTerrain.terrainData.SetDetailLayer((int)X-3,(int)Z-3, 1, DetailDens); 
					PP.SetStamina(PP.GetStamina()-2.5f);
					PlayTheDigAnim=true;
				}
				else{
					ClearText=true;
					Seconds=DateTime.Now.TimeOfDay.TotalSeconds;
					StaminaFail.text="You're too tired to dig";
				}
			}
		}
	}
}
