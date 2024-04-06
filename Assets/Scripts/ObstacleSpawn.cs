using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class ObstacleSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [FormerlySerializedAs("cooldown")] [SerializeField] private float _cooldown = 1f;
    private float _actualCooldown = 1f;
    [FormerlySerializedAs("position")] [SerializeField] private float _position;
   
    public GameObject obstacle;
    public RandomObject randomObstacle;

    private void Start()
    {
        _actualCooldown = _cooldown;
    }

    void Update()
    {
        
        _actualCooldown -= Time.deltaTime;
        if (_actualCooldown <= 0 && obstacle != null && GameManager.Instance.State!=GameManager.GameState.GameOver )
        {
            _position = Random.Range(-3f, 2.65f);
            transform.position = new Vector3(transform.position.x, _position, 0);
            Instantiate(randomObstacle.RandomObstacle(),
                this.transform.position + Vector3.left * transform.parent.position.x,
                transform.rotation, transform.parent);
            _actualCooldown = _cooldown;
        }
    }
}