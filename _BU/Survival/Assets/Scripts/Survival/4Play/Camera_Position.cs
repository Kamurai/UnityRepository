using UnityEngine;
using System.Collections;

public class Camera_Position : MonoBehaviour 
{
	public static Camera_Position Stats;
	
	public Transform myTransform;
	
	void Awake()
    {
		Stats = this;
	}
	
	// Use this for initialization
	void Start () 
	{
		myTransform = transform;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
