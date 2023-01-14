using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class Brightness : MonoBehaviour, IPointerClickHandler
{
    public GameObject Background;
    public GameObject Slider;
    public Sprite On;
    public Sprite Off;

    private Image NowImage;
    private Slider sl;
    private bool Activity = false;
    void Start()
    {
        NowImage = Background.GetComponent<Image>();
        Activity = false;
        NowImage.sprite = Off;
        sl = Slider.GetComponent<Slider>();
        sl.interactable = true;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Activity)
        {
            Activity = false;
            NowImage = Background.GetComponent<Image>();
            NowImage.sprite = Off;
            sl = Slider.GetComponent<Slider>();
            sl.interactable = true;
        }
        else
        {
            Activity = true;
            NowImage = Background.GetComponent<Image>();
            NowImage.sprite = On;
            sl = Slider.GetComponent<Slider>();
            sl.interactable = false;
        }
    }
}
