using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public SpawnData[] spawnData;

    float timer;
    int level;

    void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(level> Mathf.Min(Mathf.FloorToInt(GameManager.instance.gameTime / 15f)))
        {
            Spawn();
        }
        level = Mathf.Min(Mathf.FloorToInt(GameManager.instance.gameTime / 15f));

        if (timer > spawnData[level].spawnTime)
        {
            
            timer = 0;
            Spawn();
        }
        
    }

    void Spawn()
    {
        GameObject enemy = GameManager.instance.pool.Get(0);
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
        enemy.transform.position = spawnPoint[Random.Range(3, spawnPoint.Length)].position;
        enemy.GetComponent<Enemy>().Init(spawnData[level]);
    }
}
//buidang update code
//buidang comment
[System.Serializable]
public class SpawnData
{
    public int spriteType;
    public float spawnTime;
    public int health;
    public float speed;

}
