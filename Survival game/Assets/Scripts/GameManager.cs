using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
<<<<<<< HEAD

    public float gameTime;
    public float maxGameTime = 2 * 10f;
=======
>>>>>>> 45a962f740fd06ca80d52dd7ebf48c3ade8ccb33
    public PoolManager pool;
    public Player player;
  //  public PoolManager pool;

    public void Awake()
    {
        instance = this;   
    }
    void Update()
    {
        gameTime= Time.deltaTime;
        if(gameTime > maxGameTime)
        {
            gameTime = 0;
        }
    }
}
