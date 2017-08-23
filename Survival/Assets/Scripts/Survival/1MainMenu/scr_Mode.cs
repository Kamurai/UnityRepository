using UnityEngine;
using System.Collections;

public class scr_Mode : MonoBehaviour 
{
	public static scr_Mode Stats;
	
	public bool Tutorial;
	public bool Options;
	
	void Awake()
	{
		Stats = this;
		DontDestroyOnLoad(this);	
	}

	// Use this for initialization
	void Start () 
	{
		Stats.Tutorial = false;
		Stats.Options = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
