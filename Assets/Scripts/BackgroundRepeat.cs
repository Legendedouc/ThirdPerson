using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startPos;
    private float repeatWidth;
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth/2)
        {
            transform.position = startPos;
        }
    }


}
