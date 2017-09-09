using UnityEngine;
using System.Collections;

public class scr_Splash : MonoBehaviour 
{
	int LoadCounter = 0;
	int LoadLimit = 0;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Mouse0)) 
	    {
			ManageDisplay();
		}
		else if (Input.GetKeyDown(KeyCode.Escape)) 
	    {
			ManageDisplay();
		}
		else if (Input.GetKeyDown(KeyCode.KeypadEnter)) 
	    {
			ManageDisplay();
		}
		else if (Input.GetKeyDown(KeyCode.Return)) 
	    {
			ManageDisplay();
		}
	}
		
	void ManageDisplay()
	{
		if(LoadCounter == LoadLimit)
		{
			Application.LoadLevel("1MainMenu"); 
		}
		else
		{
			//show an image
			LoadCounter++;
		}
	}
	
	
}
