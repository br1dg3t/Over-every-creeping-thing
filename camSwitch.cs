using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour
{
    public static int countMax = 1;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
     public GameObject c5;
    public static int camCount = 1;
    private Camera c5Cam;
    private Camera c1Cam;
    private Camera c2Cam;
    private Camera c3Cam;
    private Camera c4Cam;
    public int prevBounceCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        c5Cam = c5.GetComponent<Camera>();
        c1Cam = c1.GetComponent<Camera>();
        c2Cam = c2.GetComponent<Camera>();
        c3Cam = c3.GetComponent<Camera>();
        c4Cam = c4.GetComponent<Camera>();
        c5Cam.enabled = true;
        c1Cam.enabled = false;
        c2Cam.enabled = false;
        c3Cam.enabled = false;
        c4Cam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bounceOffWall.bounceCount>prevBounceCount){
            //bounceOffWall.bounceCount = 0;
            //float x = Random.Range(0f, 0.05f);
            //float y = Random.Range(0.18f, 0.22f);
            float x = Random.Range(-.1f, 0.1f);
            float y = Random.Range(-.1f, 0.1f);
            float size = .95f;
            if(camCount==0){
                c5Cam.rect = new Rect(x,y,.25f,1f);
                c5Cam.enabled = true;
                //Invoke("cam4Off", 1);
                c4Cam.enabled = false;
            }
            else if(camCount==1){
                c1Cam.rect = new Rect(x,y,.25f,1f);
                c1Cam.enabled = true;
                //Invoke("cam1Off", 3);
                c5Cam.enabled = false;
            }
            else if(camCount==2){
                c2Cam.rect = new Rect(x,y,.25f,1f);
                c2Cam.enabled = true;
                //Invoke("cam1Off", 1);
                c1Cam.enabled = false;
            }
            else if(camCount==3){
                c3Cam.rect = new Rect(x,y,.25f,1f);
                c3Cam.enabled = true;
                //Invoke("cam2Off", 1);
                c2Cam.enabled = false;
            }
            else if(camCount==4){
                c4Cam.rect = new Rect(x,y,.25f,1f);
                c4Cam.enabled = true;
                //Invoke("cam3Off", 1);
                c3Cam.enabled = false;
                camCount=-1;
            }
            camCount++;
            Debug.Log("Cam "+camCount);
            prevBounceCount = bounceOffWall.bounceCount;
        }
    }

    void cam1Off(){
        c1Cam.enabled = false;
    }
    void cam2Off(){
        c2Cam.enabled = false;
    }
    void cam3Off(){
        c3Cam.enabled = false;
    }
    void cam4Off(){
        c4Cam.enabled = false;
    }
}
