using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    [SerializeField] GameObject sf_itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other){
        GameObject.Destroy(other.gameObject);
        GameObject.Instantiate(sf_itemPrefab, this.transform);
    }
}
