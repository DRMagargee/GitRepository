using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    
    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* void OnCollisionEnter(Collision gameObjectInformation)
     {
         if (gameObjectInformation.gameObject.name == "Player")
         {
             Debug.Log("Collision Decteded");
             SceneManager.LoadScene("Felipe_scene2");
         }
     }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Collision Detected");
            SceneManager.LoadScene(nextScene);
        }
    }
}
