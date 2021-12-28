using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
            p.velocity = - transform.right * speed;
        }
    }
}
