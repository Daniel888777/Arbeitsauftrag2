using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTrack : MonoBehaviour
{
    [SerializeField] TrackTimer trackTimer;

    private bool PassedStart, PassedCheckpoint;
    private int Lap = 0 ;
    // Start is called before the first frame update

    void Start()
    {

    }

    void Update()
    {

        var Start = PassedStart;
        var Mid = PassedCheckpoint;
        var LapNumber = Lap;
        //Debug.Log(Start);
        //Debug.Log(Mid);
       
        //Debug.Log(Lap);
            switch (Lap)
            {

                case 1:
                    trackTimer.timeFunctionLap1();
                    break;

                case 2:
                    trackTimer.timeFunctionLap2();
                    break;
                case 3:
                    trackTimer.timeFunctionLap3();
                    break;
                case 4:
                trackTimer.finalTime();
                    break;

        }
        
    }




    private void OnTriggerEnter(Collider col)

    {

        if (col.gameObject.CompareTag("StartLine") && PassedStart == false && PassedCheckpoint == false)
        {
            PassedStart = true;
            Lap += 1;
        
        }else if (col.gameObject.CompareTag("StartLine") && PassedStart == true && PassedCheckpoint == true)
        {
            Lap += 1;
            PassedCheckpoint = false;
        }

            
            
        if (col.gameObject.CompareTag("CheckLine") && PassedStart == true)
        {
            PassedCheckpoint = true;
        }
    
        
    
    }


   }
