using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takesDamage : MonoBehaviour
{
    public float type;
    public static takesDamage instance;
    public GameObject failerDetector;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hit(float type)
    {
        failDetect fD = failerDetector.GetComponent<failDetect>();

        if (type == 0)
        {
            fD.up = 150;
        }
        else if (type == 1)
        {
            fD.up = 300;
        }

    }

    /*public void RecieveDamage(float amount)
    {
        hitPoints -= amount;
        if (hitPoints <= 0)
        {
            Die();
        }
    }
    */
}

