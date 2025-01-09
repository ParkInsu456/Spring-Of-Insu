using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static bool isGameStart; //BoardScene으로 넘어갈 때???
    public static Action<int> OnPlayerLeft; //색깔 전달

    protected override void Awake()
    {
        base.Awake();
        Application.targetFrameRate = 60;
    }

    public void InitApp()
    {
        StartCoroutine(InitManagers());
    }

    private IEnumerator InitManagers()
    {
        ////Initialize ResourceManager
        //StartCoroutine(ResourceManager.Instance.Init());
        //yield return new WaitUntil(() => ResourceManager.Instance.isInitialized);

        ////Initialize UIManager
        //UIManager.Instance.Init();
        //yield return new WaitUntil(() => UIManager.Instance.isInitialized);

        //CSVParser.Instance.Init();
        //yield return new WaitUntil(() => CSVParser.Instance.isInitialized);

        PoolManager.Instance.Init();
        yield return new WaitUntil(() => PoolManager.Instance.isInitialized);


        //Initialize GameManager : 확실한 초기화 보장.
        isInitialized = true;
    }

}
