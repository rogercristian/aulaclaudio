using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
