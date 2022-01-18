using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getScore : MonoBehaviour{
    public GameObject text;
    private GameObject scoreObject;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
        score = GameManager._score;
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<UnityEngine.UI.Text>().text = "スコア:"+score.ToString();//textぶっ込み

        


    }
}
