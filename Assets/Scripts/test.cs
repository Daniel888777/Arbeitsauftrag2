using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] CarController carController;

    // Start is called before the first frame update
    void Start()
    {
        carController.WillIchAusloesen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
