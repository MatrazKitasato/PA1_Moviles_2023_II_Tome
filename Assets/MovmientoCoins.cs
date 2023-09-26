using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmientoCoins : MonoBehaviour
{
    public float speed = 4;
    private DynamicPool coins;
    void Start()
    {
        coins = GetComponent<DynamicPool>();
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
            GameManager.Instance.ships1.score += 10;
        }
    }
    private void OnBecameInvisible()
    {
        
        ReturnToPool();
    }
    void ReturnToPool()
    {
        if (coins != null)
        {
            Debug.Log("Devuelve");
            gameObject.SetActive(false);
            coins.ReturnObject(gameObject);

        }
    }
}
