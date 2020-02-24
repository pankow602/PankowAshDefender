using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    private Transform bullet;
    public float speed;

    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;
        //destroy bullet if passes game border
        if (bullet.position.y >= 30)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            //increase player score
        }
        //if player shoots the base, the base doesn't get damaged
        else if (other.tag == "base")
        {
            Destroy(gameObject);
        }
    }
}
