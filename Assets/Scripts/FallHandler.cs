using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallHandler : MonoBehaviour
{
    Rigidbody rigidbody;
    MeshRenderer meshRenderer;
    [SerializeField] float dropTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody.useGravity = false;
        meshRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        {
            rigidbody.useGravity = true;
        }
    }
}
