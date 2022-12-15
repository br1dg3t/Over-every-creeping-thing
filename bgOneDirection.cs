using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgOneDirection : MonoBehaviour
{
    public float speedhigh;
    public float speedlow;
    private float speed;
    public float sizehigh;
    public float sizelow;
    static Vector3 resetPos = new Vector3(0f,0f,0f);
    public static bool rot = false;
    public GameObject thisObj;
    private Vector3 move = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
       for (var i = 0; i<30; i++){
           if(thisObj.name == "bgMoveLeft"){
            Instantiate(thisObj, new Vector3(Random.Range(-110,110),0,0), Quaternion.Euler(0,0,0));}
       }
        speed = (float)Random.Range(speedlow,speedhigh);
        float size = Random.Range(sizelow,sizehigh);
        transform.localScale = new Vector3(size, size, size);
    }

    // Update is called once per frame
    void Update()
    {
        
        move = new Vector3(-1,0,0);
        transform.position += move * speed *0.01f;
        if (transform.position.x < -110){
            reset(new Vector3(110f,0f,0f));
        }
    }

    void reset(Vector3 resetPos){
        transform.position = resetPos;
        speed = (float)Random.Range(speedlow,speedhigh);
        float size = Random.Range(sizelow,sizehigh);
        transform.localScale = new Vector3(size, size, size);
    }
}
