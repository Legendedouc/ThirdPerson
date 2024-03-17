using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RandomObstacle", menuName = "RandomObstacle")]
public class RandomObject : ScriptableObject
{
    // Start is called before the first frame update
    public GameObject[] obstacle;



    public GameObject RandomObstacle()
    {
        int i = Random.Range(0, obstacle.Length);
        return obstacle[i];
    }
}
