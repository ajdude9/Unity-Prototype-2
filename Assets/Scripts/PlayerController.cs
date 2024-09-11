using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private int xRange = 15; //How far along the screen the player can move before being stopped.
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(transform.position.x < (xRange - xRange * 2))
        {
            transform.position = new Vector3(xRange - xRange * 2, transform.position.y, transform.position.z);
        }
        else
        {
            if(transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile when the spacebar is pressed
            
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
