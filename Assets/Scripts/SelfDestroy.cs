using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour {

    [SerializeField] float aliveTime;


    void Awake()
    {
        Destroy(transform.root.transform.gameObject, aliveTime);
    }
}
