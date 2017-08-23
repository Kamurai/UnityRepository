using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {
    GameObject player;
    RaycastHit hit;
    
    // Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        hit = new RaycastHit(); 
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (Input.GetMouseButtonDown(0)) {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                
                if (Physics.Raycast(ray, out hit, 1000.0f)) {
                    Vector3 newpos = new Vector3(hit.point.x, 0.5f, hit.point.z);
                    player.transform.position = newpos;
                }
            }
        }
	}

}
