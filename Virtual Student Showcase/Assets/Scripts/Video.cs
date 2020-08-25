using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer myVideo;

    private void OnTriggerEnter(Collider other)
    {
        myVideo.Play();
        //Debug.Log("Played");
    }
    
    private void OnTriggerExit(Collider other)
    {
        myVideo.Pause();
        //Debug.Log("Paused");
    }
}
