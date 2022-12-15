using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relocate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-50f,50f),10f,Random.Range(-30f,30f));
        StartCoroutine(newPosition());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator newPosition(){
    while(true){
        transform.position = new Vector3(Random.Range(-50f,50f),10f,Random.Range(-30f,30f));
        if (tag == "rotate"){
            Vector3 newRot = new Vector3(0, Random.Range(0,360), 0);
            transform.rotation = Quaternion.Euler(newRot);
        }
        yield return new WaitForSeconds(Random.Range(5,30));
    }
}
}
