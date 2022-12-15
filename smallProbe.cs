using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallProbe : MonoBehaviour
{
    private float speed = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, transform.position.y + speed, 0);
        if (transform.position.y > 6){
            speed = -.01f;
        } else if (transform.position.y < -1){
            speed = .01f;
        }
    }
}
