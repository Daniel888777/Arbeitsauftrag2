using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTrack : MonoBehaviour
{
    [SerializeField] TrackTimer trackTimer;
    
    private bool PassedStart, PassedCheckpoint, EndLap;
    // Start is called before the first frame update

    void Start()
    {

    }

    void Update()
    {

        var Start = PassedStart;
        var Mid = PassedCheckpoint;
        var End = EndLap;
        Debug.Log(Start);
        Debug.Log(Mid);
        Debug.Log(End);
    
        if (Start == true && End == false)
            {
            trackTimer.timeFunction();
            }
    
    
    }




    private void OnTriggerEnter(Collider col)

    {

        if (col.gameObject.CompareTag("StartLine") && PassedStart == false && PassedCheckpoint == false)
        {
            PassedStart = true;
        
        }else if (col.gameObject.CompareTag("StartLine") && PassedStart == true && PassedCheckpoint == true)
        {
            EndLap = true;
        }

            
            
            if (col.gameObject.CompareTag("CheckLine") && PassedStart == true)
        {
            PassedCheckpoint = true;
        }
    
        
    
    }


   }
