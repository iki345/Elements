using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private Collider objectCollider;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        objectCollider = GetComponent<SphereCollider>();
        objectCollider.isTrigger = true;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
