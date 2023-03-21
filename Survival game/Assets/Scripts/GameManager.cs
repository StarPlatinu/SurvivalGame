using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Object")]
    public PoolManager pool;
    public Player player;
    [Header("# Game Control")]
    public float gameTime;
    public float maxGameTime = 20 * 10f;
    [Header("# player Info")]
    public float health;
    public float maxHealth = 100;
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 10, 20, 30, 50, 70, 100, 150, 210, 450, 600 };

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }

    }

    public void GetExp()
    {
        exp++;

        if(exp == nextExp[level])
        {
            level++;
            exp = 0;
        }
    }

    
}
