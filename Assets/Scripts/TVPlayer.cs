using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVPlayer : MonoBehaviour
{
    [SerializeField] VideoClip alertVideoClip;
    [SerializeField] VideoClip offlineVideoClip;
 
    VideoPlayer vp;

    private void Start()
    {
        vp = GetComponent<VideoPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            vp.Stop();
            vp.clip = alertVideoClip;
            vp.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            vp.Stop();
            vp.clip = offlineVideoClip;
            vp.Play();
        }
    }
}
 