﻿using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 offset;
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
