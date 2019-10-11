using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failDetect : MonoBehaviour
{

    public Transform respawn;
    public int up = 0;

    void Update()
    {
        if (up > 0)
        {
            up = up - 1;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && up == 0)
        {
            other.gameObject.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
            livesManager.instance.lives = livesManager.instance.lives - 1;
            Debug.Log("Player experienced the big oof");
        }
    }
}
