using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float speed;
    public float mouseSpeed;
    public float jumpForce;
    public float DynamicJumpForce;
    public float sprintSpeed;
    public float stamina;
    float mouseX, mouseY;
    float yRotation = 0f;
    public Transform cam;
    public Rigidbody rb;
    public bool isOnground = true;
    public bool isWalk = false;
    public bool isRun = false;
    public Component staminaValue;
    private Animator character;

    private Vector3 playerMovementInput;

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        character = GetComponent<Animator>();
    }


    void Update()
    {
        stamina= staminaValue.GetComponent<StaminaBar>().stamina;
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        if (Input.GetAxis("Vertical")!=0||(Input.GetAxis("Horizontal")!=0))
        {
            character.SetBool("isWalking", true);


            Vector3 Movement = transform.TransformDirection(playerMovementInput) * speed;
            rb.velocity = new Vector3(Movement.x, rb.velocity.y, Movement.z);
            isWalk = true;
        }
        else 
        {
            character.SetBool("isWalking",false);
            isWalk = false;
         }

        if (Input.GetKey(KeyCode.LeftShift) && isWalk == true && stamina > 0)
        {
            character.SetBool("isRunning", true);

            Vector3 Movement = transform.TransformDirection(playerMovementInput) * sprintSpeed;
            rb.velocity = new Vector3(Movement.x, rb.velocity.y, Movement.z);
            isRun = true;
        }
        else
        {
            character.SetBool("isRunning", false);
            isRun = false;
        }

        if (Input.GetButtonDown("Jump") && isOnground&&isRun==false)
        {
            rb.AddForce(new Vector3(0,DynamicJumpForce, 0), ForceMode.Impulse);
            character.SetBool("isJumping", true);
            Invoke("Wait1", 1.4f);
            isOnground = false;
        }

        
 
    

        mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        yRotation -= mouseY;

        yRotation = Mathf.Clamp(yRotation, -90f, 90f);


        cam.localRotation = Quaternion.Euler(yRotation, 0, 0);
        transform.Rotate(Vector3.up * mouseX);


    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isOnground = true;
        }
    }
  
    void Wait1()
    {
        character.SetBool("isJumping", false);
    }
}
