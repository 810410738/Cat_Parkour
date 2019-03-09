﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float move_v = 50;
    public float jump_force = 50;
    private bool isGround = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //左右移动
        float h = Input.GetAxis("Horizontal");
        /*
       
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        if (h > 0.1f)
        {
            velocity.x += move_v;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
        else if (h < -0.05f)
        {
            velocity.x -= move_v;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
        */
        //修改朝向
        if (h > 0.05f)
        {
            transform.localScale = new Vector3(0.394f, 0.355f, 1);
        }
        else if (h < -0.05f)
        {
            transform.localScale = new Vector3(-0.394f, 0.355f, 1);
        }

        //跳跃
        if (isGround&&Input.GetKeyDown(KeyCode.Space))
        {
           GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump_force);
            //播放音效
            AudioManager.Instance.PlaySound("eat");
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        //碰到地面
        if (col.collider.tag == "ground")
        {
            isGround = true;
        }
    }
    public void OnCollisionExit2D(Collision2D col)
    {
        //离开地面
        if (col.collider.tag == "ground")
        {
            isGround = false;
        }
    }
}
