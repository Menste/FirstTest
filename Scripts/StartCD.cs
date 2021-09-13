using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCD : MonoBehaviour
{
    public PGMov scriptPGmov;
    public RotazionePistola scriptRotazionePistola;
    public Bullet scriptBullet;
    public Enemy scriptEnemy;
    public EnemySpawner SpawnControl;


    public Text countdownDisplay;
    void Start()
    {
        scriptPGmov.enabled = false;
        scriptRotazionePistola.enabled = false;
        scriptBullet.enabled = false;
        scriptEnemy.enabled = false;
        SpawnControl.enabled = false;
        countdownDisplay.enabled = true;


        StartCoroutine(Countdown(3));
    }

    IEnumerator Countdown(int seconds)
    {
        int count = seconds;

        while (count > 0)
        {
            countdownDisplay.text = count.ToString();
            
            yield return new WaitForSeconds(1);
            count--;
        }

        
        
        StartGame();
    }

    void StartGame()
    {
        countdownDisplay.enabled = false;
        scriptPGmov.enabled = true;
        scriptRotazionePistola.enabled = true;
        scriptBullet.enabled = true;
        scriptEnemy.enabled = true;
        SpawnControl.enabled = true;
    }
}