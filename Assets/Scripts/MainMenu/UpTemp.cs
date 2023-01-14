using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class UpTemp : MonoBehaviour, IPointerClickHandler
{
    public GameObject t;
    public int StartIndex;
    public int EndIndex;

    private TMP_Text Temperature;
    void Start()
    {
        Temperature = t.GetComponent<TMP_Text>();
        Temperature.text = StartIndex.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Temperature = t.GetComponent<TMP_Text>();
        string s=Temperature.text;
        int res = Int32.Parse(s);
        if(res == EndIndex)
        {
            return;
        }
        res++;
        s=res.ToString();
        Temperature.text = s;
    }
}
