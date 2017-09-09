using UnityEngine;
using System.Collections;

public class scr_PauseField : MonoBehaviour 
{
	public static scr_PauseField Stats;
	
	void Awake()
    {
		Stats = this;
	}
	
	// Use this for initialization
	void Start () 
	{
		scr_PauseField.Stats.guiTexture.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
