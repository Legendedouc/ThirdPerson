using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class gameSceneMove : MonoBehaviour
{
    [FormerlySerializedAs("speed")] [SerializeField] private float _speed = 5f;

    private Transform tm;
    public GameObject obstacle;
    

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.State != GameManager.GameState.GameOver)
            transform.Translate(new Vector3(-_speed * Time.deltaTime, 0, 0));
    }

    private void Awake()
    {
        tm = GetComponent<Transform>();
    }
}