using UnityEngine;

public class flipToPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private new SpriteRenderer renderer;
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        renderer.flipX = transform.position.x > player.transform.position.x;
    }
}
