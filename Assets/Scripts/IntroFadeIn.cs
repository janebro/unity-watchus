using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroFadeIn : MonoBehaviour
{
    public Canvas eventCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            eventCanvas.GetComponent<CanvasFadeIn>().SetFadeIn();
            StartCoroutine(LoadGame());
        }
    }

    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(1);
    }
}
