using UnityEngine;

public class CameraInstructions : MonoBehaviour {

    public GameObject sceneCamera;
    public Vector3 location;
    public Vector3 rotation;
    public float FOV;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IntroCameraController instructions = sceneCamera.GetComponent<IntroCameraController>();
            instructions.UpdateLocation(location);
            instructions.UpdateRotation(rotation);
            instructions.SetFOV(FOV);
        }
    }
}
