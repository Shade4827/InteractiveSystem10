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
    public GameObject Cola_CanPrefab;

    float span = 3.0f; //一秒を1スパンにする
    float delta = 0;




    void Start()
    {

        for(int i = 0; i < 5; i++)
        {
            instantiateobject();
        }

    }


    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            instantiateobject();
        }

       }

    private void instantiateobject()
    {
       
            GameObject item;
            int dice = Random.Range(1, 101); //1から100までのランダムな数字を選ぶ
            if ((dice >= 1)&&(dice<=22))
            {
                item = Instantiate(TirePrefab) as GameObject;
            }
            else if ((dice >= 23) && (dice <= 42))
            {
                item = Instantiate(Box_1Prefab) as GameObject;
            }
            else if ((dice >= 43) && (dice <= 60))
            {
                item = Instantiate(Box_2Prefab) as GameObject;
            }
            else if ((dice >= 61) && (dice <= 76))
            {
                item = Instantiate(BarrelPrefab) as GameObject;
            }
            else if ((dice >= 77) && (dice <= 90))
            {
                item = Instantiate(Barrel_ClosedPrefab) as GameObject;
            }
            else
            {
                item = Instantiate(Cola_CanPrefab) as GameObject;
            }

            float x = new float();
            float z = new float();
            x = Random.Range(0, 75);
            z = Random.Range(0, 53);
            item.transform.position = new Vector3(x, 50, z);
        
    }
}
