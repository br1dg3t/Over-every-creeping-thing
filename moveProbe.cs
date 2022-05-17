using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveProbe : MonoBehaviour
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
        if (transform.position.y > 8){
            speed = -.01f;
        } else if (transform.position.y < -3){
            speed = .01f;
        }
    }
}
