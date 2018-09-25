using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationCheat : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing = 5f;

    private void FixedUpdate()
    {
        Quaternion rot = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, smoothing * Time.deltaTime);
    }
}
