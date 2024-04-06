using System;
using UnityEngine;
using UnityEngine.Serialization;

public class CharacterFlappyMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float force;
    [FormerlySerializedAs("maxSpeed")] [SerializeField] private float _maxSpeed;
    [FormerlySerializedAs("fallSpeed")] [SerializeField] private float _fallSpeed;


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, _fallSpeed, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
  
        //Set maximum velocity of rigidbody
        if (rb.velocity.magnitude > _maxSpeed)
        { 
           
           rb.velocity = Vector3.ClampMagnitude(rb.velocity, _maxSpeed);
          
        }
        
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _fallSpeed *= -1;
            Physics.gravity = new Vector3(0, _fallSpeed, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Time.timeScale = 0;
            GameManager.Instance.changeGameState(GameManager.GameState.GameOver);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            GameManager.Instance.Highscore += 1;
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
}