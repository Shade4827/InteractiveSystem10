using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //時間関連
    [SerializeField]
    float _timeCount = 100.0f;
    [SerializeField]
    Text _timeText;
    
    //スコア関連
    int _score;
    bool _flagAddScore;
    const int ITEM_POINT = 100;
    [SerializeField]
    Text _scoreText;

    //画面遷移関連
    const string RESULT_SCENE_NAME = "Result";
    
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _flagAddScore = false;
    }

    // Update is called once per frame
    void Update()
    {
        _timeCount -= Time.deltaTime;

        _timeText.text = "残り時間:" + _timeCount.ToString("f1") + "秒";

        if(_timeCount <= 0.0f){
            SceneManager.LoadScene(RESULT_SCENE_NAME);
        }

        if(_flagAddScore){
            AddScore();
            _flagAddScore = false;
        }
    }

    public void FlagAddScore(){
        _flagAddScore = true;
    }
    
    void AddScore(){
        _score += ITEM_POINT;
        _scoreText.text = _score.ToString("D7");
    }
}
