using UnityEngine;

public class CakeController : MonoBehaviour
{
    [SerializeField] CameraGroupController setCameraShot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();
            player.GetReward();
            player.IncrementCakeCount();
            setCameraShot.ArcShot();

            Destroy(gameObject.transform.root.gameObject);
        }
    }
}
