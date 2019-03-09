using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_move : MonoBehaviour
{
    public float speed = 0.2f;
    //地面预设体
    public GameObject[] grounds;
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
            //切换地形
            //删除旧地形
           foreach(Transform trans in transform)
            {
                Destroy(trans.gameObject);
            }
            //创建新地形
            int x = Random.Range(0, grounds.Length);
            print("x is :"+x);
            Instantiate(grounds[x],transform,true);
        }
        transform.localPosition = v;
    }
}
