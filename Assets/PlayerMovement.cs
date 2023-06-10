using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator playerAnim;
    [SerializeField] private SpriteRenderer spriteRenderer, pickaxeSpriteRenderer;
    [SerializeField] private int speed = 1;
    void Update()
    {
        playerAnim.SetBool("isMoving", InputManager.Instance.MoveDirection.magnitude > 0f);

        //flips character towards mouse;
        bool flip = InputManager.Instance.MousePosition.x > transform.position.x;
        transform.localScale = new Vector3(flip? 1 : -1 ,1,1);
    }

    private void FixedUpdate() => 
        rb.MovePosition(transform.position + InputManager.Instance.MoveDirection * speed * Time.deltaTime);

 }
