using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{

    private void Awake()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }


}