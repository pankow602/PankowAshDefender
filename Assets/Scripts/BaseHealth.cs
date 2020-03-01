using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is used for giving the bases health so they may be destroyed
public class BaseHealth : MonoBehaviour
{
    public float health = 2;

    //This destroys the base if health reaches 0
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
