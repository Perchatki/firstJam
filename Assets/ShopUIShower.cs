using UnityEngine;

public class ShopUIShower : MonoBehaviour
{
    [SerializeField] private GameObject shopPanel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        shopPanel.SetActive(collision.transform.tag.Equals("Player"));
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        shopPanel.SetActive(!collision.transform.tag.Equals("Player") && shopPanel.activeSelf);
    }
}
