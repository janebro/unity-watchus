using UnityEngine;

public class CakeController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();
            player.GetReward();
            player.IncrementCakeCount();
            Destroy(gameObject.transform.root.gameObject);
        }
    }
}
