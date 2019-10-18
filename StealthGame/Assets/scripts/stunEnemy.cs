using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stunEnemy : MonoBehaviour
{

    public float cooldown = 00.0f;
    float cooldownRemaining = 0;
    float cooldownRemaining2 = 0;
    public float range = 100.0f;
    public float melee = 1f;
    public float duration = 10f;
    public float damage = 3f;
    public float type;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldownRemaining -= Time.deltaTime;
        cooldownRemaining2 -= Time.deltaTime;
        type = 0f;

        if (Input.GetKeyDown("q"))
        {
            range = 2.0f;
            type = 1f;
        }

        if (Input.GetMouseButton(0) && cooldownRemaining <= 0 || Input.GetKeyDown("q") && cooldownRemaining2 <= 0)
        {
            cooldownRemaining = cooldown;

            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, range))
            {
                Vector3 hitPoint = hitInfo.point;
                GameObject go = hitInfo.collider.gameObject;
                Debug.Log("Hit Object: " + go.name);
                Debug.Log("Hit Point: " + hitPoint);

                takesDamage t = go.GetComponent<takesDamage>();

                if (t != null)
                {
                    t.hit(type);
                }



            }
        }

        range = 100.0f;
        /*
        if (Input.GetKeyDown("q") && cooldownRemaining2 <= 0)
        {
            cooldownRemaining2 = cooldown;
            Debug.Log("Spaaaaace");

            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitInfo;


            if(hit.collider.gameObject == A1L1)
            {

            }
            if (Physics.Raycast(ray, out hitInfo, melee))
            {
                Vector3 hitPoint = hitInfo.point;
                GameObject go = hitInfo.collider.gameObject;
                Debug.Log("Hit Object: " + go.name);
                Debug.Log("Hit Point: " + hitPoint);

                takesDamage t = go.GetComponent<takesDamage>();

                if (t != null)
                {
                    t.hit();
                }



            }
        }
        */
    }
    /*
    void OnCollisionStay(Collision collisionInfo)
    {
        //Debug.Log("Target Aquired");
        if (Input.GetKeyDown("q"))
        {
            Debug.Log("Target Aquired");
            if (collisionInfo.gameObject.tag == "Dummy")
            {
                Debug.Log("BONK");
                GameObject go = collisionInfo.collider.gameObject;
                takesDamage t = go.GetComponent<takesDamage>();

                if (t != null)
                {
                    t.hit();
                }
            }
        }
    }
    */
}
