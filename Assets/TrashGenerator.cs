using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerator : MonoBehaviour
{
    public GameObject TirePrefab;
    public GameObject Box_1Prefab;
    public GameObject Box_2Prefab;
    public GameObject BarrelPrefab;
    public GameObject Barrel_ClosedPrefab;

    float span = 3.0f; //一秒を1スパンにする
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 6); //1から5までのランダムな数字を選ぶ
            if(dice == 1)
            {
                item = Instantiate(TirePrefab) as GameObject;
            }
            else if(dice == 2)
            {
                item = Instantiate(Box_1Prefab) as GameObject;
            }
            else if (dice == 3)
            {
                item = Instantiate(Box_2Prefab) as GameObject;
            }
            else if (dice ==4)
            {
                item = Instantiate(BarrelPrefab) as GameObject;
            }
            else
            {
                item = Instantiate(Barrel_ClosedPrefab) as GameObject;
            }

            float x = new float();
            float z = new float();
            x = Random.Range(0, 70);
            z = Random.Range(0, 45);
            item.transform.position = new Vector3(x, 60, z);
        }
        
    }
}
