using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_move : MonoBehaviour
{
    public float speed = 4f;
    public float move = 7f;
    private player_move player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player").GetComponent<player_move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.HP <= 0)
        {
            return;
        }
        Vector2 v = transform.localPosition;
        v.x -= speed * Time.deltaTime;
        if (v.x < -move)
        {
            v.x += move * 2;
        }
        transform.localPosition = v;
    }
}
