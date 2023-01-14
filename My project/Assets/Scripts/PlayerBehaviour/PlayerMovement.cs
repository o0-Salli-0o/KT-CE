using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D characterController;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool isJumping = false;
    bool isCrouching = false;

    public Animator animator;

    // Um zwischen den 2 Sprites abfragen zu können
    public SpriteRenderer spriteRenderer;

    public GameObject winner;

    // Start is called before the first frame update
    void Start()
    {
    spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRenderer.sprite.name == "BlobPlayer_Blue_0")
        {
            horizontalMove = Input.GetAxisRaw("Horizontal2") * runSpeed;
            if (Input.GetKey(KeyCode.W))
            {
                isJumping = true;
                animator.SetBool("IsJumping", true);
            }         
        }
        else if (spriteRenderer.sprite.name == "BlobPlayer_Pink_0")
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            if (Input.GetButtonDown("Jump"))
            {
                isJumping = true;
                animator.SetBool("IsJumping", true);
            }
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        // Move Character
        characterController.Move(horizontalMove * Time.fixedDeltaTime, isCrouching, isJumping);
        isJumping = false;
    }
}
