using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;
public class ModeManagerSet : MonoBehaviour
{
    public GameObject[] Modes;
    public GameObject[] Texts;

    private Image text;
    private void OffModes()
    {
        for (int i = 0; i < Modes.Length; i++)
        {
            Modes[i].SetActive(false);
            text = Texts[i].GetComponent<Image>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
    }
    void Start()
    {
        OffModes();
        Modes[0].SetActive(true);
        text=Texts[0].GetComponent<Image>();
        text.color= new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Quick()
    {
        OffModes();
        Modes[0].SetActive(true);
        text = Texts[0].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Lights()
    {
        OffModes();
        Modes[1].SetActive(true);
        text = Texts[1].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Locks()
    {
        OffModes();
        Modes[2].SetActive(true);
        text = Texts[2].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Display()
    {
        OffModes();
        Modes[3].SetActive(true);
        text = Texts[3].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Driving()
    {
        OffModes();
        Modes[4].SetActive(true);
        text = Texts[4].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Autopilot()
    {
        OffModes();
        Modes[5].SetActive(true);
        text = Texts[5].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Safety()
    {
        OffModes();
        Modes[6].SetActive(true);
        text = Texts[6].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Service()
    {
        OffModes();
        Modes[7].SetActive(true);
        text = Texts[7].GetComponent<Image>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
}
