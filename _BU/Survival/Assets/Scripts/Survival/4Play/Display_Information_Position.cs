using UnityEngine;
using System.Collections;

public class Display_Information_Position : MonoBehaviour 
{
	public static Display_Information_Position Stats;
	
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
		myTextMesh.text =  "Display Information: " + "\n";
		myTextMesh.text += "Information should be displayed here." + "\n";
		myTextMesh.text += "Stub.";
		
	}
}
