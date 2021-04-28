﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBorders : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private float _offset;
    void Start()
    {
        _offset = transform.position.z - _player.transform.position.z;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x ,transform.position.y, _player.transform.position.z + _offset);
    }
}