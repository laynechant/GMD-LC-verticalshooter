using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float respawnX;
    float respawnY = 6; 
    // Start is called before the first frame update
    void Start()
    {
        respawnX = transform.position.x;
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        Vector2 newPos = new Vector2(respawnX, respawnY);
        transform.position = newPos;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
