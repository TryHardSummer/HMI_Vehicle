using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class Appearance : MonoBehaviour
{
    public GameObject[] Boxes;

    void Start()
    {
        for (int i = 0; i < Boxes.Length; i++)
        {
            Boxes[i].SetActive(false);
        }
        Boxes[0].SetActive(true);

    }
    public void Mode1()
    {

        for(int i = 0; i < Boxes.Length; i++)
        {
            Boxes[i].SetActive(false);
        }
        Boxes[0].SetActive(true);
    }
    public void Mode2()
    {
        for (int i = 0; i < Boxes.Length; i++)
        {
            Boxes[i].SetActive(false);
        }
        Boxes[1].SetActive(true);

    }
    public void Mode3()
    {
        for (int i = 0; i < Boxes.Length; i++)
        {
            Boxes[i].SetActive(false);
        }
        Boxes[2].SetActive(true);

    }
}
