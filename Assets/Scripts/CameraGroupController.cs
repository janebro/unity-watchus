using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGroupController : MonoBehaviour {

    Animator rotationGroupAnim;

	// Use this for initialization
	void Start ()
    {
        rotationGroupAnim = GetComponentInChildren<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ArcShot()
    {
        rotationGroupAnim.SetTrigger("arcShot");
    }
}
