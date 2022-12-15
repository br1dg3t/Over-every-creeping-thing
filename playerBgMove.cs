using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBgMove : MonoBehaviour
{
    private InputMaster playerControls;
    public static Vector3 moveDirection = new Vector3(0f,0f,0f);
    
    private void Awake(){
        playerControls = new InputMaster();
        playerControls.Enable();
    }
   void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 prev = transform.position;
        float xDirection = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(xDirection, 0.0f, 0.0f);
    
    }
/*
    // Update is called once per frame
    void Update()
    {
        if(move.playerCam){
            gameObject.GetComponent<Camera>().enabled = true;
        }
        else{
            gameObject.GetComponent<Camera>().enabled = false;
        }
    }*/
}