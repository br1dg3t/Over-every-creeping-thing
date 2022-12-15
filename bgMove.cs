using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMove : MonoBehaviour
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
            Instantiate(thisObj, new Vector3(110,0,0), Quaternion.Euler(0,0,0));}
       }
       for (var i = 0; i<30; i++){
           if(thisObj.name == "bgMoveUp"){
            Instantiate(thisObj, new Vector3(0,0,-85), Quaternion.Euler(0,0,0));}
       }
       for (var i = 0; i<30; i++){
           if(thisObj.name == "bgMoveDown"){
            Instantiate(thisObj, new Vector3(0,0,85), Quaternion.Euler(0,0,0));}
       }
       for (var i = 0; i<30; i++){
           if(thisObj.name == "bgMoveRight"){
            Instantiate(thisObj, new Vector3(-110,0,0), Quaternion.Euler(0,0,0));}
       }
        speed = (float)Random.Range(speedlow,speedhigh);
        float size = Random.Range(sizelow,sizehigh);
        transform.localScale = new Vector3(size, size, size);

        if(tag =="right"){ move = new Vector3(1,0,0);}
        else if(tag =="left"){ move = new Vector3(-1,0,0);}
        else if(tag =="up"){ move = new Vector3(0,0,1);}
        else if(tag =="down"){ move = new Vector3(0,0,-1);}
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<60&& transform.position.x>-60 && transform.position.z>-40 && transform.position.z<40){
            tag = "center";
        }
        if (bounceOffWall.direction == "Right"){
            move = new Vector3(1,0,0);
            if (tag =="right" || tag =="center"){
                transform.position += move * speed *0.01f;
                if (transform.position.x > 110){
                    reset(new Vector3(-110f,0f,0f));
                }
            }
        } else if (bounceOffWall.direction == "Left"){
            move = new Vector3(-1,0,0);
           if (tag =="left" || tag =="center"){
                transform.position += move * speed *0.01f;
                if (transform.position.x < -110){
                    reset(new Vector3(110f,0f,0f));
                }
           }
        } else if (bounceOffWall.direction == "Up"){
            move = new Vector3(0,0,1);
           if (tag =="up" || tag =="center"){
                transform.position += move * speed *0.01f;
                if (transform.position.z > 85){
                    reset(new Vector3(0f,0f,-85f));
                }
           }
        } else { // "Down"
            move = new Vector3(0,0,-1);
           if (tag =="down" || tag =="center"){
                transform.position += move * speed *0.01f;
                if (transform.position.z < -85){
                    reset(new Vector3(0f,0f,85f));
                }
           }
        }
    }

    void reset(Vector3 resetPos){
        transform.position = resetPos;
        speed = (float)Random.Range(speedlow,speedhigh);
        float size = Random.Range(sizelow,sizehigh);
        transform.localScale = new Vector3(size, size, size);
    }
}
