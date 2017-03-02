using UnityEngine;
using System.Collections;

public class FallDetect : MonoBehaviour {
	// Use this for initialization
	void Start()
    {
        GameVariables.checkpoint = new Vector3(0, 1, 0);
    }
     void Update ()
    {
        if (transform.position.y < -100)
        {
            transform.position = GameVariables.checkpoint;
        }
            
    }