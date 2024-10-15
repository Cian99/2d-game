using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // access the rigidbody and animator of the player in the game
    private Rigidbody2D player;
    private Animator ani;
    // important to know if player grounded when making jump
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        // get the rigidbody and animator of the player object
        player = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // control meovement and way player faces
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // move left
            player.velocity = new Vector2(-5f, player.velocity.y);
            // make sprite face left
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // move right 
            player.velocity = new Vector2(5f, player.velocity.y);
            // make sprite face right
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        // if up arrow is pressed and player on the ground the call jump function
        if (Input.GetKey(KeyCode.UpArrow) && grounded)
        {
            Jump();
        }

        // if no horizontal movement then run parameter has to be false
        // this means that the player is idle and the idle animation should play
        ani.SetBool("run", Input.GetAxis("Horizontal") != 0);
        // tell animator if the player is grounded
        ani.SetBool("grounded", grounded);
        
    }

    private void Jump()
    {
        // add an upwards velocity to the player to make jump
        player.velocity = new Vector2(player.velocity.x, 10f);
        // tell the animator that the jump animation should be played
        ani.SetTrigger("jump");
        // player is no on the ground
        grounded = false;
    }

    // find when hit ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // after a jump we need to know when the player comes back to the ground
        // this says grounded is true when the player impacts with the ground
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

}
