using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class SpeedLimitMode : MonoBehaviour
{
    public GameObject Speed;

    private int speed=60;
    private TMP_Text txt;
    void Start()
    {
        txt = Speed.GetComponent<TMP_Text>();
        txt.text = "60 km/h";
    }
    public void PlusSpeed()
    {
        txt = Speed.GetComponent<TMP_Text>();
        speed += 5;
        if (speed == 105)
        {
            speed = 100;
            return;
        }
        txt.text = speed.ToString() + " km/h";
    }
    public void MinusSpeed()
    {
        txt = Speed.GetComponent<TMP_Text>();
        speed -= 5;
        if (speed == 10)
        {
            speed = 15;
            return;
        }
        txt.text = speed.ToString() + " km/h";
    }
    
}
