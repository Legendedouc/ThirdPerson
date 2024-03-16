using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlappyMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float cooldown=0.5f;
    private float actualCooldown;
    [SerializeField] private float force,maxSpeed;
    [SerializeField] private ForceMode fm;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (Input.GetKeyDown(KeyCode.Space)&&actualCooldown<=0)
        {
           
            rb.AddForce(0,force,0,fm);
            Debug.Log(rb.velocity);
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
            reset();
        }
    }


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        actualCooldown -= Time.deltaTime;
    }

    void reset()
    {
        actualCooldown = cooldown;
    }
    
    
}
