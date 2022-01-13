using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerCollision : MonoBehaviour
{
    [SerializeField]
    GameObject _gameManager;
    [SerializeField]
    GameObject _handModels;
    AudioSource _destroySE;

    void Start(){
        _destroySE = _handModels.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision){
        //ゴミに当たったら消す
        if(collision.gameObject.CompareTag("Garbage")){
            GameObject.Destroy(collision.gameObject);
            _gameManager.GetComponent<GameManager>().FlagAddScore();
            _destroySE.PlayOneShot(_destroySE.clip);
        }
    }
}
