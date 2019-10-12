using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takesDamage : MonoBehaviour
{

    public static takesDamage instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hit()
    {
        failDetect.instance.up = 300;
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