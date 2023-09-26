using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public float tiempoEntreGeneración = 2.0f;
    public float minY = -4.5f;
    public float maxY = 4.5f;
    private float tiempoUltimaGeneracion = 0.0f;
    private ObstaclessStaticPool poolEnemies;
    void Start()
    {
        poolEnemies = GetComponent<ObstaclessStaticPool>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - tiempoUltimaGeneracion > tiempoEntreGeneración)
        {
            GameObject enemy = poolEnemies.GetObstacle();

            float randomY = Random.Range(minY, maxY);
            enemy.transform.position = new Vector3(transform.position.x,randomY, 0);
            tiempoUltimaGeneracion = Time.time;
        }
    }
}
