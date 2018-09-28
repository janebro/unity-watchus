using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasFadeIn : MonoBehaviour {

    bool fadeIn = false;
    CanvasGroup canvasGroup;

	// Use this for initialization
	void Start () {
        canvasGroup = GetComponent<CanvasGroup>();
	}
	
	// Update is called once per frame
	void Update () {
        if (fadeIn)
        {
            canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, 1f, Time.deltaTime);
        }
	}

    public void SetFadeIn()
    {
        fadeIn = true;
    }
}
