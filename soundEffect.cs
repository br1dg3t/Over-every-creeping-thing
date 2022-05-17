using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffect : MonoBehaviour
{
    public AudioSource sound;
    public static bool effectPlaying;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider collision){
        effectPlaying = true;
        Debug.Log("sound");
       sound.Play();
       effectPlaying = false;
    }
}