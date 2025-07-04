using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackTimer : MonoBehaviour

{
    public TextMeshProUGUI textMeshPro;
    public float time;

   /* void Update()
    {
        time += Time.deltaTime;
        textMeshPro.text = time.ToString();
    }*/


    public void timeFunction()
    {
        time += Time.deltaTime;
        textMeshPro.text = Mathf.Round(time).ToString();
    }

}
