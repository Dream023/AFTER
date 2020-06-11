using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] static public float Speed;
    [SerializeField] CharacterController controller;
    public float Gravity = -9.81f, grounddistance = 0.1f;
    public Transform groundcheck;
    public LayerMask Ground;
    bool isGroundCheck;
    Vector3 velocity;
    private void Start()
    {
        Speed = 5f;
    }
    private void Update()
    {
        if (IsMove.ismove==true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Speed = Speed * 2;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = Speed / 2;
            }
            Move1();
        }
    }
    void Move1()
    {
        isGroundCheck = Physics.CheckSphere(groundcheck.position, grounddistance, Ground);
        if (isGroundCheck && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 Move = new Vector3(horizontal, 0f, vertical).normalized;
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (Move.magnitude >= 0.1f)
        {
            float roll = Mathf.Atan2(Move.x, Move.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, roll, 0f);
            controller.Move(Move * Speed * Time.deltaTime);
        }
    }
}

