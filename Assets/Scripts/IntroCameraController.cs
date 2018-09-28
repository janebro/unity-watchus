using UnityEngine;

public class IntroCameraController : MonoBehaviour
{
    public void UpdateLocation(Vector3 loc)
    {
        transform.position = loc;
    }

    public void UpdateRotation(Vector3 rot)
    {
        transform.rotation = Quaternion.Euler(rot);
    }

    public void SetFOV(float fov)
    {
        GetComponent<Camera>().fieldOfView = fov;
    }
}
