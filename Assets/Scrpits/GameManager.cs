using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //時間制限
    //スコア
    //画面遷移
    [SerializeField]
    float _timeCount = 30.0f;
    [SerializeField]
    Text _timeText;
    const string RESULT_SCENE_NAME = "Result";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timeCount -= Time.deltaTime;

        _timeText.text = "残り時間:" + _timeCount.ToString("f1") + "秒";

        if(_timeCount <= 0.0f){
            SceneManager.LoadScene(RESULT_SCENE_NAME);
        }
    }
}
