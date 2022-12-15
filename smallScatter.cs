using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallScatter : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        if(!obj.name.Contains("Clone")){
            for(int i = 0; i<200; i++){
                Instantiate(obj, new Vector3(Random.Range(-10,10),Random.Range(8,15),Random.Range(-8,8)), Quaternion.Euler(0,Random.Range(0,90),0)); //create clone
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
