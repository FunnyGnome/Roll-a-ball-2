using UnityEngine;
using System.Collections;

public class FallDetect : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (player.transform.position.y <= -80)
        {
            player.transform.position = new Vector3(0, 1, 0);
        }
	}
}
