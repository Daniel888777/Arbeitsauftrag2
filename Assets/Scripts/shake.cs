using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    [SerializeField] Transform visualObject;
    [SerializeField] Rigidbody theRb;
    // Start is called before the first frame update
    private float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Clamp01( theRb.velocity.magnitude/100f);
        visualObject.localPosition = Random.insideUnitSphere * 0.3f * speed;
        Debug.Log(theRb.velocity.magnitude);
        //Debug.Log(Mathf.Clamp01(theRb.velocity.magnitude / 100f));
    }
}
