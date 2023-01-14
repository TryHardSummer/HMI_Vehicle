using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class CleanMode : MonoBehaviour, IPointerClickHandler
{
    public GameObject Background;
    public Sprite On;
    public Sprite Off;
    public GameObject[] Scene;

    private Image NowImage;
    private Slider sl;
    private bool Activity = false;
    void Start()
    {
        NowImage = Background.GetComponent<Image>();
        Activity = false;
        NowImage.sprite = Off;

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Activity)
        {
            Activity = false;
            NowImage = Background.GetComponent<Image>();
            NowImage.sprite = Off;
            for(int i = 0; i < Scene.Length; i++)
            {
                Scene[i].SetActive(true);
            }
        }
        else
        {
            Activity = true;
            NowImage = Background.GetComponent<Image>();
            NowImage.sprite = On;
            for (int i = 0; i < Scene.Length; i++)
            {
                Scene[i].SetActive(false);
            }
        }
    }
}
