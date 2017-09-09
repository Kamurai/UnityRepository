using UnityEngine;
using System.Collections;

public class Camera_Slide : MonoBehaviour 
{
	public static Camera_Slide Stats;
	
	//private int height = 0;
	//private int length = 0;
	//private int width = 0;
	
	public Transform myTransform;
	
	//private int Main_Controller_Constructor.Stats.CameraSpeed;
	
	void Awake()
    {
		Stats = this;
	}
	
	// Use this for initialization
	void Start () 
	{
		myTransform = transform;
		//Main_Controller_Constructor.Stats.CameraSpeed = Main_Controller_Constructor.Stats.Main_Controller_Constructor.Stats.CameraSpeed; //null reference
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		if(Input.GetButton("Camera_Forward"))
		{
			length =+ Main_Controller_Constructor.Stats.CameraSpeed;
		}
		
		if(Input.GetButton("Camera_Backward"))
		{
			length =- Main_Controller_Constructor.Stats.CameraSpeed;
		}
		
		if(Input.GetButton("Camera_Left"))
		{
			width =- Main_Controller_Constructor.Stats.CameraSpeed;
		}
		
		if(Input.GetButton("Camera_Right"))
		{
			width =+ Main_Controller_Constructor.Stats.CameraSpeed;
		}
		*/
		if(Input.GetButton("Camera_Forward") && Camera_Position.Stats.myTransform.position.z < Main_Controller.Stats.NorthBoundary)
		{
			myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, myTransform.position.z + Main_Controller.Stats.CameraSpeed*(1));
		}
		
		if(Input.GetButton("Camera_Backward") && Camera_Position.Stats.myTransform.position.z > Main_Controller.Stats.SouthBoundary)
		{
			myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, myTransform.position.z + Main_Controller.Stats.CameraSpeed*(-1));
		}
		
		if(Input.GetButton("Camera_Left") && Camera_Position.Stats.myTransform.position.x > Main_Controller.Stats.WestBoundary)
		{
			myTransform.position = new Vector3(myTransform.position.x + Main_Controller.Stats.CameraSpeed*(-1), myTransform.position.y, myTransform.position.z);
		}
		
		if(Input.GetButton("Camera_Right") && Camera_Position.Stats.myTransform.position.x < Main_Controller.Stats.EastBoundary)
		{
			myTransform.position = new Vector3(myTransform.position.x + Main_Controller.Stats.CameraSpeed*(1), myTransform.position.y, myTransform.position.z);
		}
		
		if(Input.GetButton("Camera_Lift") && Camera_Position.Stats.myTransform.position.y < Main_Controller.Stats.CeilingBoundary)
		{
			myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y + Main_Controller.Stats.CameraSpeed*(1), myTransform.position.z);
		}
		
		if(Input.GetButton("Camera_Lower") && Camera_Position.Stats.myTransform.position.y > Main_Controller.Stats.FloorBoundary)
		{
			myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y + Main_Controller.Stats.CameraSpeed*(-1), myTransform.position.z);
		}
		
		
	}
	
	void LateUpdate()
	{
		/*
		transform.position = new Vector3(myTransform.position.x + width, myTransform.position.y + height, myTransform.position.z + length);
		width = 0;
		length = 0;
		height = 0;
		*/
	}
}
