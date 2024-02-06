using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject explosionPrefab; 
    // Start is called before the first frame update
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate (explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
       
    }
}
