﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_move_1 : MonoBehaviour
{
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = transform.localPosition;
        v.x -= speed * Time.deltaTime;
        if (v.x < -18.1f)
        {
            v.x += 18.1f * 2;
        }
        transform.localPosition = v;
    }
}