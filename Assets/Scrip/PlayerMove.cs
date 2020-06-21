using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] AudioClip Walk;
    [SerializeField] GameObject SaveUI;
    [SerializeField] static public float Speed;
    [SerializeField] CharacterController controller;
    public float Gravity = -9.81f, grounddistance = 0.1f;
    public Transform groundcheck;
    public LayerMask Ground;
    bool isGroundCheck, isThrowing = false;
    int i = 0;
    Vector3 velocity;
    float t = 0.8f, horizontal, vertical;
    bool IsMove=false;
    private void Start()
    {
        Speed = 5f;
    }
    private void Update()
    {
        if (management.IsMove == true)
        {
            if (isThrowing)
                return;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Speed = Speed * 2;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = Speed / 2;
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                Speed = 0f;
                StartCoroutine(ThrowingTime());
                return;
            }
            Move1();
        }
    }
    void Move1()
    {
        MoveCheck();
        isGroundCheck = Physics.CheckSphere(groundcheck.position, grounddistance, Ground);
        if (isGroundCheck && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Vector3 Move = new Vector3(horizontal, 0f, vertical).normalized;
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (Move.magnitude >= 0.1f)
        {
            float roll = Mathf.Atan2(Move.x, Move.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, roll, 0f);
            controller.Move(Move * Speed * Time.deltaTime);
        }
        if (IsMove == true)
        {
            AudioSource.PlayClipAtPoint(Walk, gameObject.transform.position);
        }
    }
    IEnumerator ThrowingTime()
    {
        isThrowing = true;
        yield return new WaitForSeconds(t);
        Speed = 5f;
        isThrowing = false;
    }
    void MoveCheck()
    {
        if (horizontal == 0 || vertical == 0)
        {
            IsMove = false;
            return;
        }
        else
        {
            IsMove = true;
            return;
        }
    }
}

