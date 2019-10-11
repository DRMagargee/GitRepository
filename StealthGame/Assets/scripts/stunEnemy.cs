using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stunEnemy : MonoBehaviour
{

    public float cooldown = 00.0f;
    float cooldownRemaining = 0;
    public float range = 100.0f;
    public float duration = 10f;
    public float damage = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownRemaining -= Time.deltaTime;

        if (Input.GetMouseButton(0) && cooldownRemaining <= 0)
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
                    t.hit();
                }

                

            }
        }
    }
}
