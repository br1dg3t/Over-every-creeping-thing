using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comboCam : MonoBehaviour
{
    public static int countMax = 1;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public static int camCount = 1;
    private Camera c1Cam;
    private Camera c2Cam;
    private Camera c3Cam;
    private Camera c4Cam;
    public int prevBounceCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        c1Cam = c1.GetComponent<Camera>();
        c2Cam = c2.GetComponent<Camera>();
        c3Cam = c3.GetComponent<Camera>();
        c4Cam = c4.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bounceOffWall.bounceCount>prevBounceCount){
            float x = Random.Range(-.1f, 0.1f);
            float y = Random.Range(-.1f, 0.1f);
             c1Cam.rect = new Rect(0,0+y,.25f+x,1);
             c2Cam.rect = new Rect(.25f,0+y,.25f+x,1);
             c3Cam.rect = new Rect(.5f,0+y,.25f+x,1);
             c4Cam.rect = new Rect(.75f,0+y,.25f+x,1);
            prevBounceCount = bounceOffWall.bounceCount;
        }
    }
}
