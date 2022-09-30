using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateAgitator : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Rigidbody rigidbody2;
    
    [SerializeField] Vector3 rotateDirection;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddTorque(rotateDirection, ForceMode.Force);
        rigidbody2.angularVelocity = rigidbody.angularVelocity;
    }
}