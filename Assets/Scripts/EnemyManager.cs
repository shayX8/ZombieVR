using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spArr = new Transform[8];
    static int enemyLive, enemyKilld, playerLive;
    static Text enemyScore, playerLife;
    int posx, posz;
    // Start is called before the first frame update
    void Start()
    {
        playerLive = 3;
        enemyKilld = 0;
        enemyLive = 0;
        enemyScore = GameObject.Find("EnemyKilld").GetComponent<Text>();
        playerLife = GameObject.Find("PlayerLife").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyLive < 5)
        {
            enemyLive++;
            Instantiate(enemy, spArr[Random.Range(0, 8)].position, Quaternion.identity);
        }
    }
    public static void EnemyKilld()
    {
        enemyLive--;
        enemyKilld++;
        enemyScore.text = "EnemyKilld: " + enemyKilld.ToString();
    }
    public static void HitPlayer()
    {
        playerLive--;
        if (playerLive == 0)
            SceneManager.LoadScene("YouLoseScene");
        playerLife.text = "Player Life: " + playerLive.ToString();
    }
}
