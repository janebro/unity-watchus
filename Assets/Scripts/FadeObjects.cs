using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeObjects : MonoBehaviour {

    Renderer objRenderer;

    bool fadeOut = false;

	// Use this for initialization
	void Start () {
        objRenderer = GetComponentInChildren<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (fadeOut)
        {
            objRenderer.material.color = Color.Lerp(objRenderer.material.color, new Color(1f, 1f, 1f, 0.25f), 5 * Time.deltaTime);
        }
        else
        {
            objRenderer.material.color = Color.Lerp(objRenderer.material.color, new Color(1f, 1f, 1f, 1f), 5 * Time.deltaTime);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera") fadeOut = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MainCamera") fadeOut = false;
    }
}
