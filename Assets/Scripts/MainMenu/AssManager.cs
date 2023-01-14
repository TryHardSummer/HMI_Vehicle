using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class AssManager : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] Balls;

    private int AssLevel = 0;
    void Start()
    {
        for(int i = 0; i < Balls.Length; i++)
        {
            Balls[i].SetActive(false);
        }
        AssLevel = 0;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        AssLevel++;
        if (AssLevel == Balls.Length+1)
        {
            AssLevel = 0;
            for (int i = 0; i < Balls.Length; i++)
            {
                Balls[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < AssLevel; i++)
            {
                Balls[i].SetActive(true);
            }
        }
    }
}
