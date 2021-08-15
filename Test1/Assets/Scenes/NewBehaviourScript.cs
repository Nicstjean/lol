using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject player;
    public GameObject feet;

    public Animator animator;

    private float saut = 40f;
    private float speed = 0.05f;
    
    int x = 0;

    // Start is called before the first frame update
    void Start()
    {

        animator.SetBool("isjumping", true);
        animator.SetBool("isrunning", true);

  
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("isjumping", false);
        x = 1;
    }


    void Movement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position = new Vector2(player.transform.position.x - speed, (player.transform.position.y));
            player.transform.localScale = new Vector2(-15, 15);
            animator.SetBool("isrunning", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            player.transform.position = new Vector2(player.transform.position.x + speed, (player.transform.position.y));
            player.transform.localScale = new Vector2(15, 15);
            animator.SetBool("isrunning", true);
        }

        else {
            animator.SetBool("isrunning", false);
        }


        if (Input.GetKeyDown(KeyCode.Space) && x == 1) 
        {

            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, player.GetComponent<Rigidbody2D>().velocity.y + saut);
            animator.SetBool("isjumping", true);
            x = 0;
        }

    }
}



