using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float maxYPosition = 4.5f;
    public float minYPosition = -4.5f;

    private bool isMoving = false;
    private float targetPosition;

    public float life = 3;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began )
            {
                targetPosition = Camera.main.ScreenToWorldPoint( touch.position).y;
                targetPosition = Mathf.Clamp(targetPosition, minYPosition, maxYPosition);
                isMoving = true;
            }
        }
        if(isMoving)
        {
            float step = speed * Time.deltaTime;
            Vector3 newposition = new Vector3(transform.position.x, targetPosition, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, newposition, step);
            if(transform.position.y == targetPosition || transform.position.y == maxYPosition || transform.position.y == minYPosition)
            {
                isMoving = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            life -= 1;
            if(life < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
