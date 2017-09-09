using UnityEngine;
using System.Collections;

public class scr_Tutorial : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnMouseUp()
	{
		scr_Mode.Stats.Tutorial = true;
		Application.LoadLevel("4Play"); 
	}
}
