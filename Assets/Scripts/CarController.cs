using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCOntroller : MonoBehaviour
{
    public Rigidbody theRB;

    public float forwardAccel, reverseAccel, maxSpeed, turnStrength;

    private float speedInput, turnInput; 
    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedInput = 0f;
        if(Input.GetAxis("Vertical") > 0 )
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel * 100f;

        }else if(Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel * 100f;

        }

        turnInput = Input.GetAxis("Horizontal");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime, 0f ));

        transform.position = theRB.transform.position;
    }

    private void FixedUpdate()
    {
      if (Mathf.Abs(speedInput) > 0)
        {
            theRB.AddForce(transform.forward * speedInput);

        }
    }









}
