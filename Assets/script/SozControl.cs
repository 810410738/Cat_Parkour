using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SozContorl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("dsf");
        Destroy(gameObject);
        AudioManager.Instance.PlaySound("eat");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // if (collision.tag == "player")
        //{
            print("dsf");
            Destroy(gameObject);
            AudioManager.Instance.PlaySound("eat");
       // }
    }
}
