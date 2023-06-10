using System;
using TMPro;
using UnityEngine;
using static UnityEngine.ParticleSystem;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Animator))]
public class Pickaxe : MonoBehaviour
{
    [SerializeField] private GameObject miningText;
    [SerializeField] private GameObject particles;
    private Animator pickaxeAnim;
    private bool swing;
    double addCoins;
    private void Start()
    {
        pickaxeAnim = GetComponent<Animator>();
    }
    private void Update()
    {
        InputManager.Instance.LeftMouseButtonDown.AddListener(() =>
        {
            pickaxeAnim.SetTrigger("swing");
            swing = true;
        });
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!swing) return;

        swing = false;
        if (collision.tag.Equals("Gold"))
        {
            AddCoins();
            HandleText();
            SpawnParticles();
        }
    }
    private void AddCoins()
    {
        double modificator = Random.Range(0.5f, 2);
        addCoins = EconomyManager.Instance.CoinMiningAmount * modificator;
        EconomyManager.Instance.Coins += addCoins;
    }
    private void HandleText()
    {
        _ = Instantiate(miningText, transform.position, Quaternion.identity);
        miningText.GetComponentInChildren<TMP_Text>().text = "+" +Math.Round(addCoins,1);
    }
    private void SpawnParticles()
    {
        _ = Instantiate(particles, transform.position, Quaternion.identity);
    }
}
