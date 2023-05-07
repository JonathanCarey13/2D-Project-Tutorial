using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    private float dirX;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 14f);
            Debug.ClearDeveloperConsole();
        }



        //added this but now the animation for running is being called
        //UpdateAnimationUpdate();
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }

    //private void UpdateAnimationUpdate()
    //{
    //    if (dirX > 0f)
    //    {
    //        anim.SetBool("running", true);
    //        sprite.flipX = false;
    //    }
    //    else if (dirX < 0f)
    //    {
    //        anim.SetBool("running", true);
    //        sprite.flipX = true;
    //    }
    //    else
    //    {
    //        anim.SetBool("running", false);
    //    }
    //}
}
