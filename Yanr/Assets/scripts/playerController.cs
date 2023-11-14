using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update

    private CharacterController characterController;

    float inputHorizontal;
    float inputVertical;

    public float Speed = 5f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
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
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (inputHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        
    }

}
