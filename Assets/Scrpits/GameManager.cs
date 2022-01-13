using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //時間制限関連
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

    //開始前カウントダウン
    [SerializeField]
    Text _countDownText;
    float _countDown;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _flagAddScore = false;
        _countDown = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(_countDown >= 0){
            _countDown -= Time.deltaTime;
            _countDownText.text = ((int)_countDown).ToString();
        }
        else if(_countDown <= 0){
            _countDownText.text = "";

            if(_timeCount <= 0.0f){
                StartCoroutine("ChangeScene");
            }
            else{
                _timeCount -= Time.deltaTime;
                _timeText.text = "残り時間:" + _timeCount.ToString("f1") + "秒";
            }

            if(_flagAddScore){
                AddScore();
                _flagAddScore = false;
            }
        }
    }

    public void FlagAddScore(){
        _flagAddScore = true;
    }
    
    void AddScore(){
        _score += ITEM_POINT;
        _scoreText.text = _score.ToString("D7");
    }
    
    IEnumerator ChangeScene(){
        _scoreText.text = "";
        _timeText.text = "";
        _countDownText.text = "Finish!";
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(RESULT_SCENE_NAME);
        yield return null;
    }
}
