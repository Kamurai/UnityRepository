using UnityEngine;
using System.Collections;

public class scr_Options : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseUp()
	{
		scr_Mode.Stats.Options = false;
		Application.LoadLevel("3OptionsMenu"); 
	}
}
