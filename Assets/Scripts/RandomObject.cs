using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "RandomObstacle", menuName = "RandomObstacle")]
public class RandomObject : ScriptableObject
{
    // Start is called before the first frame update
    [FormerlySerializedAs("obstacle")] public GameObject[] Obstacle;



    public GameObject RandomObstacle()
    {
        int i = Random.Range(0, Obstacle.Length);
        return Obstacle[i];
    }
}
