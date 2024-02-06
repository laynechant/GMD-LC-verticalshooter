using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject explosionPrefab;
    [ContextMenu("Damage")]
    public void TakeDamage()
    {
        PlayerHealth.setHealth(PlayerHealth.GetHealth()-1);
        if (PlayerHealth.GetHealth() < 0 )
        {
            Despawn();
        }
    }

    private void Despawn()
    {
      //  gameObject.SetActive(false);
        //GameManager.instance.UnListEnemy(gameObject);
    }
    

   

  
    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerHealth.setHealth(PlayerHealth.GetHealth() - 5);
        }
        //how and when might one have the Ship "blow up?" 
    }
}
