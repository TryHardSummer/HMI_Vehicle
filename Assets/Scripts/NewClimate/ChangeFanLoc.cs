using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class ChangeFanLoc : MonoBehaviour, IPointerClickHandler
{
    public GameObject Background;

    private bool Activity = false;
    void Start()
    {
        Background.SetActive(false);
        Activity = false;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Activity)
        {
            Activity = false;
            Background.SetActive(false);
        }
        else
        {
            Activity = true;
            Background.SetActive(true);
        }
    }
}
