using System.Collections;
 using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Timer : MonoBehaviour
{
    public float timer = 5f;
    

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene("Felipe_scene2");
        }
    }
}
