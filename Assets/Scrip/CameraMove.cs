﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Collider Player;
    void Update()
    {
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y +3, Player.transform.position.z+4);
    }
}
