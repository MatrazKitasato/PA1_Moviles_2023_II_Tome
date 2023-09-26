using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float speed = 2;
    private DynamicPool enemy;
    void Start()
    {
        enemy = GetComponent<DynamicPool>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ReturnToPool();
            GameManager.Instance.ships1.life--;
        }
    }
    private void OnBecameInvisible()
    {
        Debug.Log("FuncionaPantalla");
        ReturnToPool();
    }
    void ReturnToPool()
    {
        if(gameObject != null)
        {
            Debug.Log("Devuelve");
            //gameObject.SetActive(false);
            enemy.ReturnObject(this.gameObject);
            
        }
    }
}
