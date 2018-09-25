using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 10f;

    Vector3 movement;
    float h;
    float v;

    Animator anim;
    Rigidbody rb;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Move(h, v);
        Animate(h, v);
    }

    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);

        if (h!=0 || v!=0)
        {
            rb.MoveRotation(Quaternion.LookRotation(movement));
        }

        movement = movement.normalized * runSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }

    void Animate(float h, float v)
    {
        bool running = h != 0 || v != 0;

        anim.SetBool("isRunning", running);
    }
}
