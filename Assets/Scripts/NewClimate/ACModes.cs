using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class ACModes : MonoBehaviour
{
    public Sprite[] Scrollers;
    public GameObject[] Texts;
    public GameObject Scroller;

    private int Active = 0;
    private Image scroller;
    private TMP_Text text;
    void Start()
    {
        scroller=Scroller.GetComponent<Image>();
        scroller.sprite = Scrollers[0];
        for(int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[0].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);

    }
    public void Mode1()
    {
        scroller = Scroller.GetComponent<Image>();
        scroller.sprite = Scrollers[0];
        for(int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[0].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Mode2()
    {
        scroller = Scroller.GetComponent<Image>();
        scroller.sprite = Scrollers[1];
        for (int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[1].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
    public void Mode3()
    {
        scroller = Scroller.GetComponent<Image>();
        scroller.sprite = Scrollers[2];
        for (int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[2].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
    }
}
