using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerHealth
{
    public static event Action<int> healthChanged;
    public static int _health = 20;

    public static int GetHealth()
    {
        return _health;
    }
    public static void setHealth(int health) 
    {
        if (_health == health)
            return; 
        _health = health;
        healthChanged?.Invoke(_health);
    }
}
