using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class scr_Survivor : MonoBehaviour 
{
	public scr_Survivor Stats;
	
	public Transform myTransform;
	
	public int HitPoints;
	public int Hunger;
	public int Immunity;
	public int Defense;
	
	public float Speed;
	
	public int Melee;
	public int Shooting;
	public int Medic;
	public int Engineering;
	public int Observation;
	
	public bool isSelected;
	public float destinationX;
	public float destinationZ;
	
	public Ray ray;
	public RaycastHit hit = new RaycastHit();
    public int number = 0;
	
	void Awake()
    {
		Stats = this;
	}
	
	// Use this for initialization
	void Start () 
	{
		myTransform = transform;
		
		HitPoints = 10;
		Hunger = 3;
		Immunity = 1;
		Defense = 1;
		Speed = .01F;
		
		Melee = 1;
		Shooting = 1;
		Medic = 1;
		Engineering = 1;
		Observation = 1;
		
		isSelected = false;
		destinationX = Stats.myTransform.position.x;
		destinationZ = Stats.myTransform.position.z;
	
	}
	
	void OnMouseUp()
	{
  		// this object was clicked - do something
		if(isSelected == true)
		{
			if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) 
	        {
				isSelected = true;
			}
			else
			{
				isSelected = false;	
			}
		}
		else
		{
			isSelected = true;
		}
		
		//objectDestroy(isSelected);
	}
	
	void objectDestroy(bool input)
	{
		if(input == false)
		{
			Destroy(this.gameObject);
		}
	}
	
	/*
	 void Start () 
	 {
        player = GameObject.Find("Player");
        hit = new RaycastHit(); 
	}
	*/

	// Update is called once per frame
	void Update () 
	{
		//selection management
		if(isSelected)
		{
	        if (Input.GetKeyDown(KeyCode.Mouse0)) 
	        {
	            if (Input.GetMouseButtonDown(0)) 
	            {
					if (!(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) 
	        		{
						//deselect this
						isSelected = false;
					}
					
					Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	                
	                if (Physics.Raycast(ray, out hit, 1000.0f)) 
	                {
						if( (((Stats.transform.position.x - hit.point.x) < .1F) && ((Stats.transform.position.x - hit.point.x) > -.1F)) )
						{	
							if(((Stats.transform.position.z - hit.point.z) < .1F) && ((Stats.transform.position.z - hit.point.z) > -.1F))
							{
								//deselect this
								isSelected = true;
							}
						}
	                }
	            }
	        }
			else if (Input.GetKeyDown(KeyCode.Mouse1)) 
	        {
	            if (Input.GetMouseButtonDown(1)) 
	            {
					Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	                
	                if (Physics.Raycast(ray, out hit, 1000.0f)) 
	                {
	                    //Vector3 newpos = new Vector3(hit.point.x, 2f, hit.point.z);
	                    //Stats.transform.position = newpos;
						destinationX = hit.point.x;
						destinationZ = hit.point.z;
	                }
				}
			}
		}
		
		//action managment
		if(!Main_Controller.Stats.Pause)
		{
			//if not at destination coordinates
			if( (Stats.transform.position.x != destinationX) || (Stats.transform.position.z != destinationZ) )
			{
				if(Stats.transform.position.x < destinationX)
				{
					myTransform.position = new Vector3(myTransform.position.x + Stats.Speed*(1), myTransform.position.y, myTransform.position.z);
				}
				else if(Stats.transform.position.x > destinationX)
				{
					myTransform.position = new Vector3(Stats.transform.position.x - Stats.Speed*(1), Stats.transform.position.y, Stats.transform.position.z);
				}
				
				if(Stats.transform.position.z < destinationZ)
				{
					myTransform.position = new Vector3(Stats.transform.position.x, Stats.transform.position.y, Stats.transform.position.z + Stats.Speed*(1));
				}
				else if(Stats.transform.position.z > destinationZ)
				{
					myTransform.position = new Vector3(Stats.transform.position.x, Stats.transform.position.y, Stats.transform.position.z - Stats.Speed*(1));;
				}
				
			}
				
			
			if( (((Stats.transform.position.x - destinationX) < .01F) && ((Stats.transform.position.x - destinationX) > -.01F)) )
			{	
				if(((Stats.transform.position.z - destinationZ) < .01F) && ((Stats.transform.position.z - destinationZ) > -.01F))
				{
					destinationX = Stats.transform.position.x;
					destinationZ = Stats.transform.position.z;
				}
			}
		}
	}
	
}
