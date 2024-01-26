using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton; //this declares an instance of GameManager, allowing GameManager to always exist
    public GameObject[] enemyArray; //create an array of enemy prefabs
    public List<GameObject> activeEnemyList; //Create a list (built later from the above array) to store enemies


     void Awake() // Awake runs quite early in the game initialization process, ensuring that GameManager will exist before needed by other objects
    {
        singleton = this; // inialize the singleton with this object 
    }
    // Start is called before the first frame update
    void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy"); //load up enemyArray with any objects tagged "Enemy" 
        InitEnemies(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitEnemies() 
    {
        activeEnemyList = new List<GameObject>(); // the active enemy list needs to exist so that objects in the list can be removed (a list in c# is just a dynamic array)
        for (int i = 0; i < enemyArray.Length; i++)
        {
            activeEnemyList.Add(enemyArray[i]); // Initalize the activeEnemylist with the enemy array 
        }
    }

    void UnlistEnemy(GameObject enemy)
    {
        for (int i = 0;i < activeEnemyList.Count; i++)
        {
            if (activeEnemyList[i] == enemy)
            {
                activeEnemyList.RemoveAt(i); // remove the clicked enemy from the list
                break; 
            }
        }
        if (activeEnemyList.Count == 0)
        {
            StartCoroutine(ResetAllEnemies());
        }
    }

    IEnumerator ResetAllEnemies ()
    {
        yield return new WaitForSeconds(2);
        for (int i = 0; i < enemyArray.Length; i++) 
        {
            enemyArray[i].GetComponent<Enemy>().Respawn();
            activeEnemyList.Add(enemyArray[i]);
        }

    }

    void OnMouseDown () 
    {
        Debug.Log("down");
        gameObject.SetActive(false); // setActive to false (which deactivates the enemys)
        GameManager.singleton.UnlistEnemy(gameObject);
    }
}
