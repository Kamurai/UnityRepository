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
		
		SurvivorCount = 3;
		MedicalCount = 6;
		BuildingSupplyCount = 3;
		FoodSupplyCount = 18;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
