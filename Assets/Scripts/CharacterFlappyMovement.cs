using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlappyMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float force,maxSpeed;
    [SerializeField] private ForceMode fm;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0,force,0,fm);
        }
        //Set maximum velocity of rigidbody
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
        
    }


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    
    
}
