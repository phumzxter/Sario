using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_L2 : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator anim;

    private float horizontalInput;
    private float speed = 0.0f;
    public float gravityModifier;

    private bool onGround = false;
    private bool facingFront = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        checkOnGround();
        Move();
        Jump();
    }

    private void Idle() {
        anim.SetFloat("Speed", 0); 
    }

    private void Move() {
        horizontalInput = Input.GetAxis("Horizontal");
        // speed += Input.GetAxis("Horizontal");

        if (horizontalInput == 0) {
            anim.SetBool("Run", false);
        } else {
            bool currentFacingFront = false;
            if (horizontalInput < 0) {
                Debug.Log("Left");
                currentFacingFront = false;

                if (facingFront != currentFacingFront) {
                    facingFront = currentFacingFront;
                    RotateFacing(180);
                }
                transform.Translate(Vector3.back * horizontalInput * 5 * Time.deltaTime);
            } else {
                Debug.Log("Right");
                currentFacingFront = true;
                if (facingFront != currentFacingFront) {
                    facingFront = currentFacingFront;
                }
                transform.Translate(Vector3.forward * horizontalInput * 5 * Time.deltaTime);
            }

            anim.SetBool("Run", true);
             
        }
    }

    private void RotateFacing(int value) {
        transform.Rotate(0, value, 0);
    }

    private void Jump() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            onGround = false;
            anim.SetBool("Jump", true);
            playerRb.AddForce(Vector3.up * 18, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            onGround = true;
        }
    }

    private void checkOnGround() {
        if (onGround) {
            anim.SetBool("Jump", false);
        }
    }
}
