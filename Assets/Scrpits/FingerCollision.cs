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
    
    const int TIRE_POINT = 100;
    const int BOX_1_POINT = 200;
    const int BOX_2_POINT = 300;
    const int BARREL_POINT = 400;
    const int BARREL_CLOSE_POINT = 500;
    const int COLA_CAN_POINT = 1000;

    void Start(){
        _destroySE = _handModels.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision){
        //ゴミに当たったら消す
        if(collision.gameObject.CompareTag("Garbage")){
            string collisionName = collision.gameObject.name;
            int gotPoint = 0;

            if(collisionName.Contains("TirePrefab")){
                gotPoint = TIRE_POINT;
            }
            else if(collisionName.Contains("Box_1Prefab")){
                gotPoint = BOX_1_POINT;
            }
            else if(collisionName.Contains("Box_2Prefab")){
                gotPoint = BOX_2_POINT;
            }
            else if(collisionName.Contains("BarrelPrefab")){
                gotPoint = BARREL_POINT;
            }
            else if(collisionName.Contains("Barrel_ClosedPrefab")){
                gotPoint = BARREL_CLOSE_POINT;
            }
            else if(collisionName.Contains("Cola_CanPrefab")){
                gotPoint = COLA_CAN_POINT;
            }

            _gameManager.GetComponent<GameManager>().FlagAddScore(gotPoint);
            
            GameObject.Destroy(collision.gameObject);
            _destroySE.PlayOneShot(_destroySE.clip);
        }
    }
}
