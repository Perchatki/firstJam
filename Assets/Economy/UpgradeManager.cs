using UnityEngine;
using UnityEngine.Events;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;
    public int CoinAmountLevel;
    public int AutoMinersLevel;
    public int MinersCooldownLevel;
    public int MinersCoinAmountLevel;

    public UnityEvent CoinAmountLevelUp;
    public UnityEvent AutoMinersLevelUp;
    public UnityEvent MinersCooldownLevelUp;
    public UnityEvent MinersCoinAmountLevelUp;

    private void Start()
    {
        CoinAmountLevelUp.AddListener(() => { 
            EconomyManager.Instance.CoinMiningAmount += 1;
            CoinAmountLevel++;
        });
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }
}
