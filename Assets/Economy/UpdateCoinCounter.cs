using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateCoinCounter : MonoBehaviour
{
    void Start()
    {
        EconomyManager.Instance.OnCoinsChange.AddListener(UpdateText);
    }

    private void UpdateText()
    {
       GetComponent<TMP_Text>().text = "Монет: " +  EconomyManager.Instance.Coins;
    }
}
