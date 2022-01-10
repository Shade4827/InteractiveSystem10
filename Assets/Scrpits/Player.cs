using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float MOVE_FORCE_MULTIPLIER = 1.5f;
    float MAX_SPEED = 10.0f;
    float ROTATE_ANGLE = 1.5f;
    Rigidbody _rb;
    Vector3 _moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody>();
        _moveDirection = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = Vector3.zero;

        //W or 上キーで前に移動
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _moveDirection = this.transform.forward;
        }
        _rb.AddForce(MOVE_FORCE_MULTIPLIER * (MAX_SPEED * _moveDirection - _rb.velocity));

        //S or 下キーで停止
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _rb.velocity = Vector3.zero;
        }

        //AD or 左右キーで左右に旋回
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, -ROTATE_ANGLE, 0),Space.Self);
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, ROTATE_ANGLE, 0),Space.Self);
        }

        
    }
}
