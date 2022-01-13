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

    float span = 3.0f; //��b��1�X�p���ɂ���
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 7); //1����6�܂ł̃����_���Ȑ�����I��
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
            else if(dice ==5)
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
            item.transform.position = new Vector3(x, 60, z);
        }
        
    }
}
