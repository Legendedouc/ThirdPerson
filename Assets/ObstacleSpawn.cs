using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public float cooldown=1f;
    public float actualCooldown=1f;
    public float position;
    public GameObject obstacle;
    // Update is called once per frame

    private void Start()
    {
       
    }


    void Update()
    {
        actualCooldown -= Time.deltaTime;
        if (actualCooldown <= 0)
        {
            position = Random.Range(-3f, 2.65f);
            transform.position = new Vector3(transform.parent.position.x, position, 0);
            Instantiate(obstacle,this.transform.parent.position,transform.rotation);
            actualCooldown = cooldown;
        }
    }
}
