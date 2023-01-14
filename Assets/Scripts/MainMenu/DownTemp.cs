using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class DownTemp : MonoBehaviour, IPointerClickHandler
{
    public GameObject t;
    public int StartIndex;

    private TMP_Text Temperature;

    public void OnPointerClick(PointerEventData eventData)
    {
        Temperature = t.GetComponent<TMP_Text>();
        string s = Temperature.text;
        int res = Int32.Parse(s);
        if (res == StartIndex)
        {
            return;
        }
        res--;
        s = res.ToString();
        Temperature.text = s;
    }
}
