using UnityEngine;
using UnityEngine.UI;

public class IntroFadeIn : MonoBehaviour
{
    public Canvas eventCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            eventCanvas.GetComponent<CanvasFadeIn>().SetFadeIn();
        }
    }
}
