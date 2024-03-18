using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _startPos;
    private float _repeatWidth;
    void Start()
    {
        _startPos = transform.position;
        _repeatWidth = GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < _startPos.x - _repeatWidth/2)
        {
            transform.position = _startPos;
        }
    }


}
