using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
        public float bash;


    void Update() 
    {
        transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles + new Vector3(0, 100 * Time.deltaTime, 0));

    }

        private void OnTriggerEnter(Collider col)

        {

            if (col.gameObject.CompareTag("Player"))
            {
                var rb = col.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * bash, ForceMode.Impulse);
            }
        }
    

}
