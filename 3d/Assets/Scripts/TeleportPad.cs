using UnityEngine;
using System.Collections;

public class TeleportPad : MonoBehaviour {
    public int code;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            foreach(Teleporter tp in FindObjectsOfType<Teleporter>())
            {
                if(tp.code==code&& tp != this)
                {
                    Vector3 postion = tp.gameObject.transform.position;
                    postion.y += 2;
                    collider.gameObject.transform.position = position;
                
                }
            }
        }
    }
}
