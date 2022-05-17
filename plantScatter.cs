using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantScatter : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        if(!obj.name.Contains("Clone")){
            for(int i = 0; i<200; i++){
                Instantiate(obj, new Vector3(Random.Range(-50,50),22,Random.Range(-25,25)), Quaternion.Euler(0,0,0)); //create clone
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
