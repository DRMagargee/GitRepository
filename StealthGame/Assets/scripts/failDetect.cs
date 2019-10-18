using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failDetect : MonoBehaviour
{
    public static failDetect instance;
    public Transform respawn;
    public int up = 0;
    public Renderer glow;


    private void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (up > 0)
        {
            up = up - 1;
            glow.enabled = false;
        }

        if (up == 0)
            glow.enabled = true;

        if (Input.GetKeyDown("p"))
        {
            up = 300;
        }
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player" && up == 0)
        {
            other.gameObject.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
            livesManager.instance.lives = livesManager.instance.lives - 1;
            Debug.Log("Player experienced the big oof");
        }
    }


}

