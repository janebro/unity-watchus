using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGroupController : MonoBehaviour {

    [SerializeField] GameObject playCam;

    Animator rotationGroupAnim;

    Vector3 cameraOriginalPos;

	// Use this for initialization
	void Start ()
    {
        rotationGroupAnim = GetComponentInChildren<Animator>();
        cameraOriginalPos = playCam.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ArcShot()
    {
        SetPosition(new Vector3(0,6,-5));
        rotationGroupAnim.SetTrigger("arcShot");
        StartCoroutine(ResetCamera(2f));
    }

    IEnumerator ResetCamera(float inTime)
    {
        yield return new WaitForSeconds(inTime);
        ReturnPosition();
    }

    public void SetPosition(Vector3 newPosition)
    {
        playCam.GetComponent<BoxCollider>().enabled = false;
        playCam.transform.localPosition = newPosition;
    }

    public void ReturnPosition()
    {
        playCam.transform.localPosition = cameraOriginalPos;
        playCam.GetComponent<BoxCollider>().enabled = true;
    }
}
