using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruibles : MonoBehaviour
{
    public float resistencia; //resietencia de nuestro objetos 
    public GameObject explosion;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.magnitude > resistencia)
        {
            if (explosion != null)
            {
                var go = Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(go, 3);
            }
            Destroy(gameObject, 0.1f);
        }
        else
        {
            resistencia -= col.relativeVelocity.magnitude;

        }
    }

   
}
