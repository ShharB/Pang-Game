using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerManger : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed = 3f;

    private float input;

    private bool flipPlayerR;

    [SerializeField]
    private Rigidbody2D playerRg;

    [SerializeField]
    private Animator playerAnimator;

    [SerializeField]
    private SpriteRenderer playerSprit;

    private void Start()
    {
        GameManger.instance.SetPlayerSpriteRenderer(playerSprit);
    }


    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        input = CrossPlatformInputManager.GetAxis("Horizontal");

        if (input < 0 && !flipPlayerR)
        {
            Flip();
        }
        else if (input > 0 && flipPlayerR)
        {
            Flip();
        }

        playerRg.velocity = new Vector2(movementSpeed* input, playerRg.velocity.y);
        playerAnimator.SetFloat("speed",Mathf.Abs(input));
    }


    private void Flip()
    {
        flipPlayerR = !flipPlayerR;
        transform.Rotate(0f, 180f, 0f);
    }

 

}
