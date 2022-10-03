using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 direction;
    public float forwardSpeed;

    private int desiredLane = 1; // 0 left, 1 middle, 2 right
    public float laneDistance = 4;//the distance between lanes
 
    public float jumpForce;
    public float gravity = -20f;

    public Animator anim;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        direction.z = forwardSpeed;
          direction.y += gravity * Time.deltaTime;
        if (characterController.isGrounded)
        {
            //direction.y = -1;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
           /* else
            {
                direction.y += gravity * Time.deltaTime;
            }
           */
        }

     


        if (Input.GetKeyDown(KeyCode.D))
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if(desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;

        }else if(desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, 80 * Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        characterController.Move(direction * Time.fixedDeltaTime);

    }

    private void Jump()
    {
        direction.y = jumpForce;
        anim.SetTrigger("Jump");
    }
}
