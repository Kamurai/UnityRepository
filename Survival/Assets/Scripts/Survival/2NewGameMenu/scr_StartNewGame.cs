using UnityEngine;
using System.Collections;

public class scr_StartNewGame : MonoBehaviour 
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
		Application.LoadLevel("4Play"); 
	}
}
