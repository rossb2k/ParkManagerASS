using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update

    private CharacterController characterController;
    public Animator animator;

    float inputHorizontal;
    float inputVertical;

    bool facingRight;
    bool facingLeft;
    bool isWalking;

    public float Speed = 3f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        characterController.Move(move * Time.deltaTime * Speed);

        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (inputHorizontal > 0)
        {
            // gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            animator.SetBool("facingRight", true);
            animator.SetBool("facingLeft", false);
            animator.SetBool("isWalking", true);
            animator.SetFloat("inputHorizontal", inputHorizontal);
            
        }


        else if (inputHorizontal < 0)
        {
            // gameObject.transform.localScale = new Vector3(-1f, 1f, 1f);
            animator.SetBool("facingLeft", true);
            animator.SetBool("facingRight", false);
            animator.SetBool("isWalking", true);
            animator.SetFloat("inputHorizontal", inputHorizontal);
        
        }

        else
        {
            animator.SetBool("isWalking", false);
        }

        
    }

}
