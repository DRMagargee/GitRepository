﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public void SceneLoader(int SceneIndex)
    {
        Debug.Log("NextLevel");
        SceneManager.LoadScene(SceneIndex);
    }
}
