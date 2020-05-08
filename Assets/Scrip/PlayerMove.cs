using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody Player;
    [SerializeField] float Speed,Roll;
    private void Start()
    {
        Speed = 500f;
        Roll = 0.0f;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Player.velocity = transform.forward * Speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (Roll != 0)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                    Roll = 0.0f;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Speed = Speed * 2;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = Speed / 2;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != 45)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, 45f, 0.0f);
                    Roll = 45f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                Roll = 0.0f;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != -45)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, -45f, 0.0f);
                    Roll = -45f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                Roll = 0.0f;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Player.velocity = transform.forward * Speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (Roll != 180)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                    Roll = 180.0f;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Speed = Speed * 2;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = Speed / 2;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != 135)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, 135f, 0.0f);
                    Roll = 135f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                Roll = 180.0f;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != -135)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, -135f, 0.0f);
                    Roll = -135f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                Roll = 180.0f;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Player.velocity = transform.forward * Speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (Roll != 90)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                    Roll = 90.0f;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Speed = Speed * 2;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = Speed / 2;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != 45)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, 45f, 0.0f);
                    Roll = 45f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                Roll = 90.0f;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != 135)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, 135f, 0.0f);
                    Roll = 135f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                Roll = 90.0f;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Player.velocity = transform.forward * Speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (Roll != -90)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
                    Roll = -90.0f;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Speed = Speed * 2;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = Speed / 2;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != -45)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, -45f, 0.0f);
                    Roll = -45f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
                Roll = -90.0f;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                Player.velocity = transform.forward * Speed * Time.deltaTime;
                if (Roll != -135)
                {
                    Player.transform.rotation = Quaternion.Euler(0.0f, -135f, 0.0f);
                    Roll = -135f;
                }
                else if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = Speed * 2;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = Speed / 2;
                }
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                Player.transform.rotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
                Roll = -90.0f;
            }
        }
    }
}
