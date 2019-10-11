using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failDetect : MonoBehaviour
{

    public Transform respawn;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
        }
    }

    
}
