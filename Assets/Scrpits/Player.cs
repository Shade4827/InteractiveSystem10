using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーオブジェクトに力を加えて移動
        //WASD or 上下左右キーで移動
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(0,0,1);
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(-1,0,0);
        }
        
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(0,0,-1);
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(1,0,0);
        }
    }
}
