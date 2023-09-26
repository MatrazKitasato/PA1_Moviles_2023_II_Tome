using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclessStaticPool : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int poolSize = 10;

    public List<GameObject> obstaclePool;

    private void Start()
    {
        obstaclePool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefab);
            obstacle.SetActive(false);
            obstaclePool.Add(obstacle);
        }
    }

    public GameObject GetObstacle()
    {
        foreach (var obstacle in obstaclePool)
        {
            if (!obstacle.activeInHierarchy)
            {
                obstaclePool.Remove(obstacle);
                obstacle.SetActive(true);
                return obstacle;
            }
        }
        return null;
    }

    public void ReturnObstacle(GameObject obstacle)
    {
        if(obstacle != null && obstacle.activeInHierarchy)
        {
            obstacle.SetActive(false);
            obstaclePool.Add(obstacle);
        }
    }
}
