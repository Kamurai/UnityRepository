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
		myTextMesh.text += "Camera Y: " + (Camera_Slide.Stats.myTransform.position.y).ToString();
		
	}
}
