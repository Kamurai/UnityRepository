using UnityEngine;
using System.Collections;

public class Main_Controller : MonoBehaviour 
{
	public static Main_Controller Stats;
	
	public int CameraSpeed;
	
	public int NorthBoundary;
	public int SouthBoundary;
	public int EastBoundary;
	public int WestBoundary;
	public int CeilingBoundary;
	public int FloorBoundary;
	
	public bool Pause;
	public bool PauseEnabled;
	
	public int SurvivorCount;
	public int MedicalCount;
	public int BuildingSupplyCount;
	public int FoodSupplyCount;
	

	void Awake()
    {
		Stats = this;
	}
	
	// Use this for initialization
	void Start () 
	{
		CameraSpeed = 1;
		NorthBoundary = 150;
		SouthBoundary = -150;
		EastBoundary = 150;
		WestBoundary = -150;
		CeilingBoundary = 150;
		FloorBoundary = 5;
		
		Pause = false;
		PauseEnabled = true;
		
		SurvivorCount = 3;
		MedicalCount = 6;
		BuildingSupplyCount = 3;
		FoodSupplyCount = 18;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			if(PauseEnabled)
			{
				if(Pause)
				{
					Pause = false;
					
					scr_PauseField.Stats.guiTexture.enabled = false;
					
					//GameObject.Destroy(OptionsField);
				}
				else
				{
					Pause = true;
					
					scr_PauseField.Stats.guiTexture.enabled = true;
					
					//SetOptionsField();
				}	
				
				
			}
		}
				
	}
	
	
	void SetOptionsField()
	{
		GameObject OptionsField = new GameObject("OptionsField");
		OptionsField.AddComponent("GUITexture");
		OptionsField.transform.localScale = Vector3.zero;
		
		
		OptionsField.guiTexture.pixelInset = new Rect(50,50,1000,500);
				
		Texture2D OptionsFieldTexture = new Texture2D(1,1);
		OptionsFieldTexture.SetPixels(new Color[1] {Color.gray});
		OptionsFieldTexture.Apply ();
		OptionsField.guiTexture.texture = OptionsFieldTexture;
	}
	
	
	
}
