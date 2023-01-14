using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class ClimateSettings : MonoBehaviour, IPointerClickHandler
{
    public GameObject Climate;
    public GameObject Main;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject[] Menu;

    private int Index;
    void Start()
    {
        Climate.SetActive(false);
        Point1.SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Climate.activeSelf == true)
        {
            Climate.SetActive(false);
            Point1.SetActive(false);
            Point2.SetActive(false);
            Menu[Index].SetActive(true);   
        }
        else
        {
            Climate.SetActive(true);
            Point1.SetActive(true);
            for(int i = 0; i < Menu.Length; i++)
            {
                if (Menu[i].activeSelf == true)
                {
                    Index = i;
                }
            }
            Menu[Index].SetActive(false);
        }
    }
}
