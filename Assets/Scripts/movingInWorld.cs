using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingInWorld : MonoBehaviour
{
    private Vector3 _targetPos, _startPos;
    public float minDuration, maxDuration;
    private float duration;
    private float passedTime, percentageComplete;


    [SerializeField] private float height;

    // Start is called before the first frame update
    void Start()
    {
        duration = Random.Range(minDuration, maxDuration);
        _targetPos = transform.position;
        transform.position = new Vector3(transform.position.x, _targetPos.y + height, transform.position.z);
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _startPos.x = transform.position.x;
        _targetPos.x = transform.position.x;
        passedTime += Time.deltaTime;
        transform.position = Vector3.Lerp(_startPos, _targetPos, passedTime / duration);
    }
}