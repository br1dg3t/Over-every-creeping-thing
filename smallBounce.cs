using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallBounce : MonoBehaviour
{
    public float speed;
    public static string direction;
    public AudioSource sound;
    public static int bounceCount = 0;
    public static bool effectPlaying;
   // public GameObject arrow;

    //private float size;
    // Start is called before the first frame update
    void Start()
    {
        //arrow.SetActive(false);
        transform.position = new Vector3(Random.Range(-10f,10f),transform.position.y,Random.Range(-10f,10f));
        Vector3 newRot = new Vector3(0, Random.Range(0,360), transform.rotation.eulerAngles.z);
        //Vector3 newRot = new Vector3(Random.Range(-10, 10), Random.Range(0,360), transform.rotation.eulerAngles.z);
        transform.rotation = Quaternion.Euler(newRot);
        sound = GetComponent<AudioSource>();
        //size = Random.Range(0.5f,.5f);
        //transform.localScale = new Vector3(size,size,size);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed *0.005f;
        //Debug.Log(transform.rotation.eulerAngles.y % 360);
        if (transform.position.x >50f){ // right --> 
            moveLeft();
            if (transform.rotation.eulerAngles.y%360 > 90){ clock(); } // -
            else{counter();} // +
        }
        else if (transform.position.x < -50f){ // <-- left
            moveRight();
            if (transform.rotation.eulerAngles.y%360 < 270){ counter(); } // -
            else{clock();} // +
        }
        if (transform.position.z > 25f){ // up 
            moveDown();
             if (transform.rotation.eulerAngles.y%360 > 90){ counter(); } // -
            else{clock();} // +
        }
        else if (transform.position.z < -25f){ // down
            moveUp();
            if (transform.rotation.eulerAngles.y%360 > 180){ clock(); } // -
            else{counter();} // +
        }
    }

    void counter(){
        //arrow.transform.position = new Vector3(transform.position.x, 16, transform.position.z);
        //arrow.SetActive(true);
        effectPlaying = true;
        Invoke("effectPlayingFalse",0.5f);
        string turn = "counter";
        float angle = getAngle(turn);
        Vector3 newRot = new Vector3(-transform.rotation.eulerAngles.x + Random.Range(-3,3), angle, transform.rotation.eulerAngles.z + Random.Range(-10,10));
        transform.rotation = Quaternion.Euler(newRot);
        bounceCount++;
        sound.Play();
    }

    void clock(){
        //arrow.transform.position = new Vector3(transform.position.x, 16, transform.position.z);
        //arrow.SetActive(true);
        effectPlaying = true;
        Invoke("effectPlayingFalse",0.5f);
        string turn  = "clock";
        float angle = getAngle(turn);
        Vector3 newRot = new Vector3(-transform.rotation.eulerAngles.x + Random.Range(-3,3), angle, transform.rotation.eulerAngles.z + Random.Range(-10,10));
        transform.rotation = Quaternion.Euler(newRot);
        bounceCount++;
        sound.Play();
    }

    float getAngle(string turn){
        float currRot = transform.rotation.eulerAngles.y%360;
        if(currRot%90==0){
            currRot+=5;
        }
        if (turn == "counter"){
            if (currRot < 90){
                return(360-currRot);
            } else if (currRot < 180){
                return(180-currRot);
            } else if (currRot < 270){
                return(90+(270-currRot));
            } else {
                return(180+(360-currRot));
            }
        } else if (turn == "clock"){
            if (currRot < 90){
                return(180-currRot);
            } else if (currRot < 180){
                return(180+(180-currRot));
            } else if (currRot < 270){
                return(360 - (currRot - 180));
            } else {
                return (90-(currRot - 270));
            } 
        } else{
            return(0f);
        }
    }

    void moveLeft(){
        transform.position = new Vector3(transform.position.x - 3,transform.position.y,transform.position.z);
        direction = "Right";
    }
    void moveRight(){
        transform.position = new Vector3(transform.position.x + 3,transform.position.y,transform.position.z);
        direction = "Left";
    }
    void moveUp(){
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+3);
        direction = "Down";
    }
    void moveDown(){
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-3);
        direction = "Up";
    }

    void effectPlayingFalse(){
        effectPlaying = false;
        //arrow.SetActive(false);
    }
}
