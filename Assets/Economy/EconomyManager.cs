using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class EconomyManager : MonoBehaviour
{
    public static EconomyManager Instance;

    public UnityEvent OnCoinsChange;
    public double Coins { 
        get => coins; 
        set { coins = Math.Round(value, 1); 
            OnCoinsChange.Invoke(); } }

    public double CoinMiningAmount { 
        get => Math.Round(coinMiningAmount * Random.Range(0.5f,2f));
        set => coinMiningAmount = value; }

    private double coins = 1;
    private double coinMiningAmount = 1;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }


}