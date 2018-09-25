using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVPlayer : MonoBehaviour
{
    VideoPlayer vp;

    private void Start()
    {
        vp = GetComponent<VideoPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        vp.Stop();
        vp.Play();
    }
}
 