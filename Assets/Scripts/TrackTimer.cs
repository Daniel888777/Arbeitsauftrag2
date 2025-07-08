using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackTimer : MonoBehaviour

{
    public TextMeshProUGUI textMeshPro1;
    public TextMeshProUGUI textMeshPro2;
    public TextMeshProUGUI textMeshPro3;
    public float timeLap1;
    public float timeLap2;
    public float timeLap3;

    /* void Update()
     {
         time += Time.deltaTime;
         textMeshPro.text = time.ToString();
     }*/
    private void Start()
    {
        textMeshPro1.text = "Lap 1";
        textMeshPro2.text = "Lap 2";
        textMeshPro3.text = "Lap 3";
    }

    public void timeFunctionLap1()
    {
        timeLap1 += Time.deltaTime;
        textMeshPro1.text = Mathf.Round(timeLap1).ToString();
    }

    public void timeFunctionLap2()
    {
        timeLap2 += Time.deltaTime;
        textMeshPro2.text = Mathf.Round(timeLap2).ToString();
    }

    public void timeFunctionLap3()
    {
        timeLap3 += Time.deltaTime;
        textMeshPro3.text = Mathf.Round(timeLap3).ToString();
    }
}
