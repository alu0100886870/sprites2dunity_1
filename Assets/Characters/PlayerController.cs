using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator animator;
    private SpriteRenderer sp;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
        

        if (vertical > 0)
        {
            animator.SetInteger("Direction", 8);
        }
        else if (vertical < 0)
        {
            animator.SetInteger("Direction", 2);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("Direction", 6);
            sp.flipX = true;
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("Direction", 4);
            sp.flipX = false;
        }

        if (vertical == 0 && horizontal == 0)
            animator.enabled = false;
        else
            animator.enabled = true;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        float speed = 2.0f;
        transform.position += move * speed * Time.deltaTime;
        

    }
}