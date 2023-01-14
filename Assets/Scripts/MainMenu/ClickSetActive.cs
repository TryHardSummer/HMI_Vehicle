using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;



public class ClickSetActive : MonoBehaviour, IPointerClickHandler
{
    public GameObject Point;
    public GameObject Icon;
    public Sprite On;
    public Sprite Off;

    private Image Now;
    void Start()
    {
        Point.SetActive(false);
        Now = Icon.GetComponent<Image>();
        Now.sprite = Off;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Point.activeSelf == true)
        {
            Point.SetActive(false);
            Now = Icon.GetComponent<Image>();
            Now.sprite = Off;
        }
        else
        {
            Point.SetActive(true);
            Now = Icon.GetComponent<Image>();
            Now.sprite = On;
        }
    }

}