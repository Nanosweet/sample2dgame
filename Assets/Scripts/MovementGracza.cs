using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGracza : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sprite;

    float dirX = 0f;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;



    //[SerializeField] float moveSpeed, jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        AnimationRunningUpdate();        
               

    }

    private void AnimationRunningUpdate()
    {
        if (dirX > 0f)
        {
            animator.SetBool("isRunning", true);
            sprite.flipX = false; 
        }
        else if (dirX < 0f)
        {
            animator.SetBool("isRunning", true);
            sprite.flipX = true;
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

    private void AnimationJumpingUpdate()
    {
        
    }

    //You don't need to hold both keys at the same time.
    //You only need to keep Ctrl held down, press K (release it) and then F (release Ctrl now). 
    // Ctrl + R zmiana nazwy w calym kodzie
}
