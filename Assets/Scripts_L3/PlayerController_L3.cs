using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_L3 : MonoBehaviour
{
    public float runSpeed;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 5.0f;
    private float jumpHeight = 3.5f;
    private float gravityValue = -9.81f;
    public int state;
    private bool idleState;
    private Animator mAnimator;
    private int jumpCount;
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        idleState = true;
        mAnimator = GetComponent<Animator>();
        jumpCount = 0;
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 0) {
            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
            }

            // float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            if (groundedPlayer) {
                mAnimator.SetFloat("horizontal", horizontal);
                mAnimator.SetInteger("jumpAnim", 0);
                mAnimator.SetBool("is_on_air", false);
            } else {
                mAnimator.SetFloat("horizontal", 0);
                int randomJumpAnim =  Random.Range(1,3); //random animation number 0 or 1
                mAnimator.SetInteger("jumpAnim", randomJumpAnim);
                mAnimator.SetBool("is_on_air", true);
            }

            Vector3 moveHorizontal = new Vector3(horizontal, 0, 0);
            // Vector3 moveVertical = new Vector3(gameObject.transform.position.x, vertical, gameObject.transform.position.z);
            controller.Move(moveHorizontal * Time.deltaTime * playerSpeed);

            if (moveHorizontal != Vector3.zero)
            {
                gameObject.transform.forward = moveHorizontal;
                idleState = false;
                
            } else {
                idleState = true;
            }

            // Changes the height position of the player..
            if (Input.GetKeyDown("space") && groundedPlayer && state == 0)
            {
                // Debug.Log(randomJumpAnim);
                // mAnimator.SetBool("is_on_air", true);
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }

        
        
            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
    }}

    public void OnDieState() {
        // mAnimator.enabled = false;
        // mAnimator.SetTrigger("is_gameover");
        mAnimator.Play("Die");
       Destroy(gameObject, 6f); // not work
        if (mAnimator.GetCurrentAnimatorStateInfo(0).length > mAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime) 
         {
            mAnimator.ResetTrigger("is_gameover");
             
        }
        
    }

    
}
