using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*public float speed;
    public float jump;

    private float Move;

    public Rigidbody2D rb;

    public bool isJumping;*/



    public CharacterController2D characterController;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool isJumping = false;
    bool isCrouching = false;

    public Animator animator;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
    spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            isCrouching = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            isCrouching = false;
        }
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove)); */

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

            if (Input.GetButtonDown("Crouch"))
            {   
                isCrouching = true;
            }
            else if (Input.GetButtonUp("Crouch"))
            {
                isCrouching = false;
            } 
        }
        








        /*Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(Move * speed));

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }*/
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

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }*/
}
