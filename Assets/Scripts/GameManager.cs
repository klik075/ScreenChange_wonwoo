using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get ; private set; }

    public int coinCount = 0; //È¹µæ ÇÑ ÄÚÀÎÀÇ ¼ö
    private void Awake()
    {
        Init();
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public void Init()
    {
        coinCount = 0;
    }
    public void AddCoin(int num)
    {
        coinCount += num;
    }
}
