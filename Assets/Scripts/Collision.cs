using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    
    public float jump;

    private void OnTriggerEnter(Collider col)

    {
        
        if (col.gameObject.CompareTag("Player"))
        {
            var rb = col.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
    }
}
