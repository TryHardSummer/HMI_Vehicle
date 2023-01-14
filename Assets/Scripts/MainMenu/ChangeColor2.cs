using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;


public class ChangeColor2 : MonoBehaviour
{
    public GameObject[] Items;
    public GameObject Img;
    public Sprite[] Scrollers;

    private TMP_Text text;
    private TMP_Text TEXT;
    private GameObject tl;
    private Image Cover;

    void Start()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            text = Items[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        TEXT = Items[0].GetComponent<TMP_Text>();
        TEXT.color = new Vector4(43 / 255.0f, 41 / 255.0f, 255 / 255.0f, 1);
        int index = Find(Items[0]);
        Cover = Img.GetComponent<Image>();
        Cover.sprite = Scrollers[index];
    }
    public void Click(GameObject eventData)
    {
        tl = eventData;
        for (int i = 0; i < Items.Length; i++)
        {
            text = Items[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        TEXT = tl.GetComponent<TMP_Text>();
        TEXT.color = new Vector4(43 / 255.0f, 41 / 255.0f, 255 / 255.0f, 1);
        int index = Find(tl);
        Cover = Img.GetComponent<Image>();
        Cover.sprite = Scrollers[index];
    }
    int Find(GameObject f)
    {
        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] == f)
            {
                return i;
            }
        }
        return -1;
    }
}

