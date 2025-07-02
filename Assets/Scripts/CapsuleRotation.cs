using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotation : MonoBehaviour
{
    public GameObject capsule;
    
    public float turnStrength, selfCorrect;

    private float turnInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = -Input.GetAxis("Horizontal");

        var currentRot = (180 + transform.localEulerAngles.z) % 360 - 180;
       // Debug.Log("Euler:" + currentRot);
       // Debug.Log("Turninput:" + turnInput);

        if (Mathf.Abs(currentRot) < 45f)
        {
            transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles + new Vector3(0f, 0f, turnInput * turnStrength * Time.deltaTime));
        }
        else
        {

            if (currentRot > 0f)
            {
                transform.localRotation = Quaternion.Euler(0f, 0f, 44.9f);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0f, 0f, -44.9f);

            }

        }

        if (turnInput == 0)
        {
            if (currentRot > 1f)
            {
                transform.localRotation = Quaternion.Euler(0f, 0f, currentRot -= selfCorrect);
            }
            else if (currentRot < -1f)
            {
                transform.localRotation = Quaternion.Euler(0f, 0f, currentRot += selfCorrect);
            }
        }
    }
}
