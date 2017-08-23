using UnityEngine;
using System.Collections;

public class Display_Camera_Position : MonoBehaviour 
{
	public static Display_Camera_Position Stats;
	
	public Transform myTransform;
	public TextMesh myTextMesh;
	
	void Awake()
    {
		Stats = this;		
	}
	
	// Use this for initialization
	void Start () 
	{
		myTransform = transform;
		
		myTextMesh.text = "Monkeys!";
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		myTextMesh.text =  "Camera X: " + (Camera_Slide.Stats.myTransform.position.x).ToString() + "\n";
		myTextMesh.text += "Camera Z: " + (Camera_Slide.Stats.myTransform.position.z).ToString() + "\n";
		myTextMesh.text += "Camera Y: " + (Camera_Slide.Stats.myTransform.position.y).ToString() + "\n" + "\n";
		
		myTextMesh.text += "Mouse X: " + (Input.mousePosition.x).ToString() + "\n";
		myTextMesh.text += "Mouse Y: " + (Input.mousePosition.y).ToString() + "\n";
		myTextMesh.text += "Mouse Z: " + (Input.mousePosition.z).ToString() + "\n" + "\n";
		
		if((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
		{
			myTextMesh.text += "Shift: True";
		}
		else
		{
			myTextMesh.text += "Shift: False";	
		}
		
		myTextMesh.text += "\n" + "\n";
		
		if (GameObject.Find("Mode") != null)
		{
		
		
			if(scr_Mode.Stats.Tutorial)
			{
				myTextMesh.text += "Tutorial: True";
			}
			else
			{
				myTextMesh.text += "Tutorial: False";	
			}
		
		}
		
		//myTextMesh.text += "Selected: " + (scr_Survivor.Stats.isSelected).ToString() + "\n";
		//myTextMesh.text += "Position X: " + (scr_Survivor.Stats.myTransform.position.x).ToString() + " Destination X: " + (scr_Survivor.Stats.destinationX).ToString() + "\n";
		//myTextMesh.text += "Position Z: " + (scr_Survivor.Stats.myTransform.position.z).ToString() + " Destination Z: " + (scr_Survivor.Stats.destinationZ).ToString();
		
	}	
}
