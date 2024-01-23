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
        StartCoroutine(Co_ShootRoutine());
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


    IEnumerator Co_ShootRoutine()
    {
        while (true)
        {
           // yield return new WaitForEndOfFrame();
            yield return new WaitForSeconds(0.5f);
           // yield return new WaitForSeconds(1.0f);
            Shoot();
        }
        
    }
}
