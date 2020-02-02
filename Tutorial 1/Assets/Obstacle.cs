using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    bool moveRight = true;

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y > 9.49) {
            moveRight = false;
        }
        if (transform.position.y < -9.49)
        {
            moveRight = true;
        }

        if (moveRight)
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
    }
}
