using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerCollision : MonoBehaviour
{
    [SerializeField]
    GameObject gameManager;

    void OnCollisionEnter(Collision collision){
        //ゴミに当たったら消す
        if(collision.gameObject.CompareTag("Garbage")){
            GameObject.Destroy(collision.gameObject);
            gameManager.GetComponent<GameManager>().FlagAddScore();
        }
    }
}
