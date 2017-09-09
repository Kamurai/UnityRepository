using UnityEngine;
using System.Collections;

public class Display_Resources_Position : MonoBehaviour 
{
	public static Display_Resources_Position Stats;
	
	public Transform myTransform;
	public TextMesh myTextMesh;
	
	private float xDiff;
	private float zDiff;
	private float yDiff;
	
	void Awake()
    {
		Stats = this;
		
		myTextMesh.text = "Monkeys!";
		
		//xDiff = myTransform.position.x - Camera_Slide.Stats.myTransform.position.x;
		//zDiff = myTransform.position.z - Camera_Slide.Stats.myTransform.position.z;
		//yDiff = myTransform.position.y - Camera_Slide.Stats.myTransform.position.y;
		
		
	}
	
	// Use this for initialization
	void Start () 
	{
		myTransform = transform;
		
		myTextMesh.text = "Monkeys!";
		
		xDiff = myTransform.position.x - Camera_Slide.Stats.myTransform.position.x;
		zDiff = myTransform.position.z - Camera_Slide.Stats.myTransform.position.z;
		yDiff = myTransform.position.y - Camera_Slide.Stats.myTransform.position.y;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		myTextMesh.text =  "Survivors: " + (Main_Controller.Stats.SurvivorCount).ToString() + "\n";
		myTextMesh.text += "Food: " + (Main_Controller.Stats.FoodSupplyCount).ToString() + "\n";
		myTextMesh.text += "Medical Kits: " + (Main_Controller.Stats.MedicalCount).ToString() + "\n";
		myTextMesh.text += "Building Supplies: " + (Main_Controller.Stats.BuildingSupplyCount).ToString();
		
		//myTransform.position = new Vector3((Camera_Slide.Stats.myTransform.position.x + xDiff), (Camera_Slide.Stats.myTransform.position.y + yDiff), (Camera_Slide.Stats.myTransform.position.z + zDiff));
		
	}
}
