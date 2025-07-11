using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackTimer : MonoBehaviour

{
    public TextMeshProUGUI textMeshPro1;
    public TextMeshProUGUI textMeshPro2;
    public TextMeshProUGUI textMeshPro3;
    public TextMeshProUGUI textMeshPro4;
    public float timeLap1;
    public float timeLap2;
    public float timeLap3;
    public float timeTotal;

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
        textMeshPro4.text = "Time Total";
    }

    public void timeFunctionLap1()
    {
        timeLap1 += Time.deltaTime;
        //decimal roundedValue = timeLap1;
        //textMeshPro1.text = Mathf.Round(roundedValue, 2).ToString();
        textMeshPro1.text = timeLap1.ToString("N2");
    }

    public void timeFunctionLap2()
    {
        timeLap2 += Time.deltaTime;
        textMeshPro2.text = timeLap2.ToString("N2");
    }

    public void timeFunctionLap3()
    {
        timeLap3 += Time.deltaTime;
        textMeshPro3.text = timeLap3.ToString("N2");
    }

    public void finalTime()
    {
        timeTotal = timeLap1 + timeLap2 + timeLap3;
        textMeshPro4.text = timeTotal.ToString("N2");
    }
}
