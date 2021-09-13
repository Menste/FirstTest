using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject bulletPrefab;
    public Transform Player;
    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("MainPG").transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainPG")
        {
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "Bullet")
        {
            
            Destroy(enemyPrefab);
            Destroy(bulletPrefab);
        }
    }
    
        

    }
