using UnityEngine;
using System.Collections;

public class Camera_Slide : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("A"))
		{
			Transform.position.x += -1.0;
		}
		else if(Input.GetButtonDown("D"))
		{
			Transform.position.x += 1.0;
		}
		else if(Input.GetButtonDown("W"))
		{
			Transform.position.y += 1.0;
		}
		else if(Input.GetButtonDown("S"))
		{
			Transform.position.y += -1.0;
		}
	}
}
