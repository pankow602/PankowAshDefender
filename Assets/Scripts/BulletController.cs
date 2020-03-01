using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script basically controls where the bullet spawns and how it moves,
//along with destroying itself after going far enough off the map
public class BulletController : MonoBehaviour
{

    private Transform bullet;
    public float speed;
    
    //this component finds where the bullet starts
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    //destroy bullet if passes game border
    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;
        if (bullet.position.y >= 30)
        {
            Destroy(gameObject);
        }
    }

    //this determines how the bullet interacts with different game objects
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
        }
        //if player shoots the base, the base doesn't get damaged
        else if (other.tag == "base")
        {
            Destroy(gameObject);
        }
    }
}
