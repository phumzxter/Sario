using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_L1 : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;
    public float jumpForce = 10;
    public float gravity = -20;

    public GameObject GameOverScreen;

    public Transform groundCheck;
    public LayerMask groundLayer; 

    public bool ableToMakeDoubleJump = false;

    public Animator anim;
    public Transform model;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        float hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed;

        anim.SetFloat("speed", Mathf.Abs(hInput));

        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);
        anim.SetBool("isGrounded", isGrounded);

        if (isGrounded)
        {
            direction.y = -1;
            ableToMakeDoubleJump = true;
            if (Input.GetButtonDown("Jump"))
            {
                direction.y = jumpForce;
            }
        }
        else 
        {
            direction.y += gravity * Time.deltaTime;
            if(ableToMakeDoubleJump & Input.GetButtonDown("Jump"))
            {
                direction.y = jumpForce;
                ableToMakeDoubleJump = false;
            }
        }
        if(hInput != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(hInput, 0, 0));
            model.rotation = newRotation;

        }
        
        controller.Move(direction * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerManager.numberOfEnemy++;
            var enemy = other.gameObject.GetComponent<Goomba_L1>();
        }
        
    }
}

    
