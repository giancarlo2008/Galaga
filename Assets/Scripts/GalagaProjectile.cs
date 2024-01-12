using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalagaProjectile : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//
    
    // === Create a Rigidbody2D variable for the projectile/bullet === //
    Rigidbody2D rigidbody2d;


    void Awake()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
         rigidbody2d = GetComponent<Rigidbody2D>();

    }
    
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }
    
    void Update()
    {
        if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

      void OnCollisionEnter2D(Collision2D other)
      {
    
      EnemyController e =other.collider.GetComponent<EnemyController>();
      if (e != null)
      {
        Destroy(other.gameObject);
      }
      Destroy(gameObject);
    }

}