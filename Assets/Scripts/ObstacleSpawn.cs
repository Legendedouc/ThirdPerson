using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class ObstacleSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float cooldown = 1f;
    private float actualCooldown = 1f;
    [SerializeField] private float position;

    public GameObject obstacle;
    public RandomObject randomObstacle;

    private void Start()
    {
        Debug.Log("Hello World");
        actualCooldown = cooldown;
    }

    void Update()
    {
        actualCooldown -= Time.deltaTime;
        if (actualCooldown <= 0 && obstacle != null)
        {
            position = Random.Range(-3f, 2.65f);
            transform.position = new Vector3(transform.position.x, position, 0);
            Instantiate(randomObstacle.RandomObstacle(),
                this.transform.position + Vector3.left * transform.parent.position.x,
                transform.rotation, transform.parent);
            actualCooldown = cooldown;
        }
    }


    void DestroyAfterSeconds()
    {
    }
}