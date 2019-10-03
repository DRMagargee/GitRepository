using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       void OnCollisionEnter(Collision gameObjectInformation)
        {
            if(gameObjectInformation.gameObject.name == "Player")
            {
                Debug.Log("Collision Decteded");
                SceneManager.LoadScene("Felipe_scene2");
            }
        } 
    }
}
