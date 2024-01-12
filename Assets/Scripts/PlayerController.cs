using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//
    // === Create a float variable for the speed of the player === //
    public float speed = 10;
    
    

    // === Create a Rigidbody2D variable for the player === //
    Rigidbody2D rigidbody2d;

    // === Create a float variable for the player's Left and Right input === //
    float horizontal;
   
    // === Create a public GameObject variable for the projectile prefab === //
     public GameObject projectileprefab;
    
    
    
    void Start()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
        rigidbody2d = GetComponent<Rigidbody2D>();


    }

    void Update()
    {
        // === Write the code below to set your input variable EQUAL to the player's horizontal inputs (HINT: use ' Input.GetAxis() ') === //
       horizontal = Input.GetAxis("Horizontal");
       Vector3 position = transform.position;
       transform.Translate(Vector3.right * speed * horizontal * Time.deltaTime);
       
        // === Create an if-statement below to get the player's key down and then call the method to launch your projectile/bullet === //
        // ~ HINT: use ' Input.GetKeyDown() ' ~ //

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
    }
 
   
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectileprefab, transform.position + Vector3.up * 2.0f, Quaternion.identity);

        GalagaProjectile projectile = projectileObject.GetComponent<GalagaProjectile>();
        projectile.Launch(Vector2.up, 800);

    }
    
}
