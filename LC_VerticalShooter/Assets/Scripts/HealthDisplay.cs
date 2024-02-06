using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Image[]_heartImages;
    [SerializeField] private int numSegments = 4;
    private void OnEnable()
    {
        PlayerHealth.healthChanged += OnHealthChanged; 
        OnHealthChanged(PlayerHealth.GetHealth());
    }

    private void OnDisable()
    {
        PlayerHealth.healthChanged -= OnHealthChanged;
    }
    private void OnHealthChanged(int health)
    {
        Debug.Log("Health" + health);
        for (int i = 0; i < _heartImages.Length; i++) 
        {
            _heartImages[i].fillAmount = (health - i  * numSegments) / (float)numSegments;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
