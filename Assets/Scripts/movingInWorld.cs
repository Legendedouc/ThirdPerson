using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingInWorld : MonoBehaviour
{
    private Vector3 targetPos, startPos;
    public float minDuration, maxDuration;
    private float duration;
    private float passedTime, percentageComplete;


    [SerializeField] private float height;

    // Start is called before the first frame update
    void Start()
    {
        duration = Random.Range(minDuration, maxDuration);
        targetPos = transform.position;
        transform.position = new Vector3(transform.position.x, targetPos.y + height, transform.position.z);
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        startPos.x = transform.position.x;
        targetPos.x = transform.position.x;
        passedTime += Time.deltaTime;
        transform.position = Vector3.Lerp(startPos, targetPos, passedTime / duration);
    }
}