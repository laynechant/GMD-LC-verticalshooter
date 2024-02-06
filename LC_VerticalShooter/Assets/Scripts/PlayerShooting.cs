using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public float bulletSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    
    private void Shoot()
    {
        
        
            // shoot bullet
            Rigidbody2D bulletRB = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            bulletRB.velocity = transform.up * bulletSpeed;
            Destroy(bulletRB.gameObject, 2.0f);


        
    }
}
