using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieEngin : MonoBehaviour
{
    GameObject player;
    float speed;
    float f = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        transform.LookAt(player.transform);
        if (Vector3.Distance(transform.position, player.transform.position) < 1)
        {
            EnemyManager.HitPlayer();
            Destroy(this.gameObject);
        }
    }

    public void KillEnemy()
    {
        Destroy(this.gameObject);
        EnemyManager.EnemyKilld();
    }
    
}
