using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static: 정적으로 사용하겠다는 키워드, 바로 메모리에 얹어버림.
    public static GameManager instance;
    public PoolManager pool;
    public Player player;

    public float gameTime;
    public float maxGameTime = 2 * 10f;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }
    }
}