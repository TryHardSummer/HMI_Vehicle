using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ChangeColorBlue : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] Items;

    private Image img;
    private bool homecolor = true;

    void Start()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            img = Items[i].GetComponent<Image>();
            img.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (homecolor)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                img = Items[i].GetComponent<Image>();
                img.color = new Vector4(43 / 255.0f, 41 / 255.0f, 255 / 255.0f, 1);
            }
        }
        else
        {
            for (int i = 0; i < Items.Length; i++)
            {
                img = Items[i].GetComponent<Image>();
                img.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
            }
        }
        homecolor = !homecolor;
    }


}
