using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;


public class ArrowEnDis : MonoBehaviour, IPointerClickHandler
{
    public GameObject Arrow;
   

    private Image Color;

    private bool Active = false;
    void Start()
    {
        Color = Arrow.GetComponent<Image>();
        Color NewColor;
        ColorUtility.TryParseHtmlString("#FFFFFF", out NewColor);
        Color.color = NewColor;
        Active = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Active == true)
        {
            Color = Arrow.GetComponent<Image>();
            Color NewColor;
            ColorUtility.TryParseHtmlString("#FFFFFF", out NewColor);
            Color.color = NewColor;
            Active = false;
        }
        else
        {
            Color = Arrow.GetComponent<Image>();
            Color NewColor;
            ColorUtility.TryParseHtmlString("#0081DE", out NewColor);
            Color.color=NewColor;
            Active = true;
        }
    }
}
