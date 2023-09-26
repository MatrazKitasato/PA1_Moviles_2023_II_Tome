using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public float tiempoEntreGeneraci�n = 2.0f;
    public float minY = -4.5f;
    public float maxY = 4.5f;
    private float tiempoUltimaGeneracion = 0.0f;
    private DynamicPool poolEnemies;
    void Start()
    {
        poolEnemies = GetComponent<DynamicPool>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - tiempoUltimaGeneracion > tiempoEntreGeneraci�n)
        {
            GameObject enemy = poolEnemies.GetObject();

            float randomY = Random.Range(minY, maxY);
            enemy.transform.position = new Vector3(transform.position.x,randomY, 0);
            tiempoUltimaGeneracion = Time.time;
        }
    }
}
