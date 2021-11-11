using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        //ゴミに当たったら消す
        if(collision.gameObject.CompareTag("Garbage")){
            GameObject.Destroy(collision.gameObject);
        }
    }
}
