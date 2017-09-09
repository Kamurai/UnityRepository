using UnityEngine;
using System.Collections;

public class scr_NewGame : MonoBehaviour 
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
		scr_Mode.Stats.Tutorial = false;
		Application.LoadLevel("2NewGameMenu"); 
	}
}
