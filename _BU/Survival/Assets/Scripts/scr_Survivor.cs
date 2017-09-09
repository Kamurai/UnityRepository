using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class scr_Survivor : MonoBehaviour 
{
	public static scr_Survivor Stats;
	
	public Transform myTransform;
	
	public Ray ray;
	public RaycastHit hit = new RaycastHit();
    
	
	public int HitPoints;
	public int Hunger;
	public int Melee;
	public int Shooting;
	public int Defense;
	public int Medic;
	public int Engineering;
	public int Observation;
	
	public bool isSelected;
	
	
	void Awake()
    {
		Stats = this;
	}
	
	// Use this for initialization
	void Start () 
	{
		myTransform = transform;
		
		HitPoints = 10;
		Defense = 1;
		Hunger = 3;
		Defense = 1;
		
		Melee = 1;
		Shooting = 1;
		Defense = 1;
		Medic = 1;
		Engineering = 1;
		Observation = 1;
		
		isSelected = false;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		selection();
       	if(isSelected)
       	{
        	Debug.Log("Selected");
         	return;
       	}
		else
		{
			
		}
	}
	
	void selection()
    {
		/*
       ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       if(Input.GetKey(KeyCode.Mouse0))
       {
         if(Physics.Raycast(ray,hit,100))
         {
         	isSelected = true;
         }
       }
       */
    }
}
