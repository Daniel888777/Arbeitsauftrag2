using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    
    public float boost;

    private void OnTriggerEnter(Collider col)

    {
        
        if (col.gameObject.CompareTag("Player"))
        {
            var rb = col.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * boost, ForceMode.Impulse);
        }
    }





}
