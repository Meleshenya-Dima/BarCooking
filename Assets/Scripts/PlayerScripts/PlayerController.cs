using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 3f;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        GetInputAxis();   
    }

    private void GetInputAxis()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = 5f;
        }
        else
        {
            _speed = 3f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("NotBackWalk");
            animator.SetTrigger("NotRightWalk");
            animator.SetTrigger("NotLeftWalk");

            transform.position += _speed * Time.deltaTime * transform.forward;
            animator.SetTrigger("Walk");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("NotRightWalk");
            animator.SetTrigger("NotLeftWalk");
            animator.SetTrigger("NotWalk");

            transform.position += _speed * Time.deltaTime * -transform.forward;
            animator.SetTrigger("BackWalk");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("NotLeftWalk");
            animator.SetTrigger("NotWalk");
            animator.SetTrigger("NotBackWalk");

            transform.position += _speed * Time.deltaTime * transform.right;
            animator.SetTrigger("RightWalk");
        }

        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("NotRightWalk");
            animator.SetTrigger("NotWalk");
            animator.SetTrigger("NotBackWalk");

            transform.position += _speed * Time.deltaTime * -transform.right;
            animator.SetTrigger("LeftWalk");
        }
        else
        {
            animator.SetTrigger("NotRightWalk");
            animator.SetTrigger("NotWalk");
            animator.SetTrigger("NotBackWalk");
            animator.SetTrigger("NotLeftWalk");
        }
    }
}
