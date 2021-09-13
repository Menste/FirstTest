using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefabEnemy;
    public Transform[] spawnPoint;
     float enemyCount;

    public float count;
    public GameObject[] instantiatedPrefab;

    


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabEnemy, spawnPoint[0].transform.position, Quaternion.identity);
        Instantiate(prefabEnemy, spawnPoint[1].transform.position, Quaternion.identity);
        Instantiate(prefabEnemy, spawnPoint[2].transform.position, Quaternion.identity);

    }


    void Update()
    {
        
        
        instantiatedPrefab = GameObject.FindGameObjectsWithTag("Enemy");
        count = instantiatedPrefab.Length;
        enemyCount = count;
        

        spawnOfEnemies();
        print("sono" + enemyCount);
       
        




    }

    void spawnOfEnemies()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, spawnPoint.Length - 1));
        if (enemyCount < 3)
        {
            Instantiate(prefabEnemy, spawnPoint[randomNumber].transform.position, Quaternion.identity);
            
        }
    }

}
