using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class ExcludeMode : MonoBehaviour
{
    public GameObject[] Buttons;
    public Sprite On;
    public Sprite Off;

    private Image img;
    void Start()
    {
        for(int i = 0; i < Buttons.Length; i++)
        {
            img = Buttons[i].GetComponent<Image>();
            img.sprite = Off;
        }
        img = Buttons[0].GetComponent<Image>();
        img.sprite = On;
    }
    public void Mode1()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            img = Buttons[i].GetComponent<Image>();
            img.sprite = Off;
        }
        img = Buttons[0].GetComponent<Image>();
        img.sprite = On;
    }
    public void Mode2()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            img = Buttons[i].GetComponent<Image>();
            img.sprite = Off;
        }
        img = Buttons[1].GetComponent<Image>();
        img.sprite = On;
    }
    public void Mode3()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            img = Buttons[i].GetComponent<Image>();
            img.sprite = Off;
        }
        img = Buttons[2].GetComponent<Image>();
        img.sprite = On;
    }

}
