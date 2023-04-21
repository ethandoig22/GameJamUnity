using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float Timer;
    public float enemySpawnTimer;
    public Vector2 enemySpawn;
    public AudioSource waterDroplet;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Timer += 2 * Time.deltaTime;
       

        if (Timer >= enemySpawnTimer)
        {
            Timer = 0;
            enemySpawn = new Vector2(Random.Range(-230, 230), transform.position.y);
            Spawn();
        }
    }

    public void Spawn()
    {
        Instantiate(Enemy, enemySpawn, Quaternion.identity);
        waterDroplet.Play();
    }

    public void WrongChoice()
    {
        enemySpawnTimer -= 0.5f;

    }
}
