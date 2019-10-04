using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPath : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current = 0;


    // Update is called once per frame
    void Update()
    {
        //if (transform.position.y != 1.049093)
        //    gameObject.transform.position = new Vector3(transform.position.x, 1.049093f, transform.position.y);


        if (transform.position.x != target[current].position.x || transform.position.z != target[current].position.z)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            
            Vector3 eulerRotation = new Vector3(transform.eulerAngles.x, target[current].transform.eulerAngles.y, transform.eulerAngles.z);
            transform.rotation = Quaternion.Euler(eulerRotation);
            current = (current + 1) % target.Length;
            //transform.Rotate(0, -90, 0);
        }
    }
}
