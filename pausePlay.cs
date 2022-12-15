using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausePlay : MonoBehaviour
{
     public AudioSource voiceover;
    // Start is called before the first frame update
    void Start()
    {
        voiceover = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bounceOffWall.effectPlaying){
            Debug.Log("pause");
            voiceover.Pause();
            Invoke("unpause", 5f);
        }
    }

    void unpause(){
        voiceover.UnPause();
    }
}
