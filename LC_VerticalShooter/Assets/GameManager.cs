using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton; //this declares an instance of GameManager, allowing GameManager to always exist
    public GameObject[] enemyArray; //create an array of enemy prefabs
    public List<GameObject> activeEnemyList; //Create a list (built later from the above array) to store enemies


    private void Awake()
    {
        singleton = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
