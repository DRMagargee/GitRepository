using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class livesManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static livesManager instance;
    public int lives = 3;
    public string failScene;

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            SceneManager.LoadScene(failScene);
            lives = 3;
        }
    }
}
