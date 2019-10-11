using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRotate : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;

    public float rot1;
    public float rot2;
    public int facing = 0;


    // Update is called once per frame
    void Update()
    {
        /*
        if (transform.rotation.eulerAngles.y == rot1)// 0
        {
            facing = 0;
        }
        if (transform.rotation.eulerAngles.y == rot2)// 90
        {
            facing = 3;
        }
        */


        if (facing > 3)
        {
            transform.Rotate(0, ( (rot2 - rot1) / 3), 0);// 0 - 90 = -90
            facing = facing + 1;
        }
        else
        {
            transform.Rotate(0, ( (rot1 - rot2) / 3), 0);// 90 - 0 = 90
            facing = facing + 1;
        }

        if (facing == 6)
            facing = 0;
     
        
    }
}
