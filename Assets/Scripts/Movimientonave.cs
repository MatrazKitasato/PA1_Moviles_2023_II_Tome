using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientonave : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(5.0f * Time.deltaTime, 0, 0);
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(transform.position.y < 3 || transform.position.y > - 3)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    rb.AddForce(Vector2.up * force, ForceMode2D.Force);
                }
                else if (touch.phase == TouchPhase.Stationary)
                {
                    rb.AddForce(Vector2.up * force, ForceMode2D.Force);
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    rb.velocity *= 0.25f;
                }
            }
        }
    }
}
