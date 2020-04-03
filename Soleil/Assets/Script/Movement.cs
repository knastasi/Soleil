using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runspeed = 40f;
    float horizontalmove = 0f;
    bool jump = false;
    bool crouch = false;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
    	horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;

        animator.SetFloat("run", Mathf.Abs(horizontalmove));

        if (Input.GetButtonDown("Jump"))
		{
            jump = true;
            animator.SetBool("isjumping", true);
		}
        if(Input.GetButtonDown("crouch"))
		{
            crouch = true;
		}
        else if(Input.GetButtonUp("crouch"))
		{
            crouch = false;
		}
    }

    public void onlanding()
	{
        animator.SetBool("isjumping", false);
	}

    public void oncrouching(bool iscrouching)
	{
        animator.SetBool("iscrouching", iscrouching);
	}

    private void FixedUpdate()
    {
    	controller.Move(horizontalmove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
