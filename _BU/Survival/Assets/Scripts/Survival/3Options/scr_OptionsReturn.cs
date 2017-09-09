using UnityEngine;
using System.Collections;

public class scr_OptionsReturn : MonoBehaviour {

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
		if((GameObject.Find("Mode") != null) && (scr_Mode.Stats.Options))
		{
			Application.LoadLevel("4Play");
		}
		else
		{
			Application.LoadLevel("1MainMenu");
		}
	}
	
	
	
		
}
