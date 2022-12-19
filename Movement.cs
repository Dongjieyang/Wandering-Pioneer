using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float mouseSpeed;
    public float jumpForce;
    public float sprintSpeed;
    public float stamina;
    float mouseX, mouseY;
    float yRotation = 0f;
    public Transform cam;
    public Rigidbody rb;
    public bool isOnground = true;
    public bool isWalk = false;
    public Component staminaValue;
    private Animator character; 
  


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        character = GetComponent<Animator>();
    }


    void Update()
    {
        stamina= staminaValue.GetComponent<StaminaBar>().stamina;
        

        if (Input.GetAxis("Vertical")!=0||(Input.GetAxis("Horizontal")!=0))
        {
            character.SetBool("isWalking", true);
            transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
            transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
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
            transform.Translate(0, 0, Input.GetAxis("Vertical") * sprintSpeed * Time.deltaTime);
            transform.Translate(Input.GetAxis("Horizontal") * sprintSpeed * Time.deltaTime, 0, 0);
            
        }
        else
        {

            character.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Jump")&& isOnground)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            
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
}
