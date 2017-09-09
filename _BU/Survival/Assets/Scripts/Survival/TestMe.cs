using UnityEngine;
using System.Collections;

public class TestMe : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			//DestroyObject(gameObject);	
		}
	}
	
	void OnMouseUp()
	{
		DestroyObject(gameObject);	
	}
}
