using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float speed = 2;
    private ObstaclessStaticPool enemy;
    void Start()
    {
        enemy = GetComponent<ObstaclessStaticPool>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ReturnToPool();
            GameManager.Instance.ships1.life--;
            Debug.Log("aaa");
        }
    }
    private void OnBecameInvisible()
    {
        ReturnToPool();
    }
    void ReturnToPool()
    {
        
        
        enemy.ReturnObstacle(gameObject);
        Debug.Log("xxxxxxxxxxxxxxxxxx");
        gameObject.SetActive(false);

    }
}
