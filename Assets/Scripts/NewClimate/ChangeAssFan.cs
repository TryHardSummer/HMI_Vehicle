using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class ChangeAssFan : MonoBehaviour
{
    public GameObject[] Backgrounds;
    public GameObject[] Points1;
    public GameObject[] Points2;

    private int LevelPoint1=1;
    private int LevelPoint2=1;
    void Start()
    {
        for(int i = 0; i < Backgrounds.Length; i++)
        {
            Backgrounds[i].SetActive(false);
        }
        Backgrounds[2].SetActive(true);
        for (int i = 0; i < Points1.Length; i++)
        {
            Points1[i].SetActive(false);
        }
        Points1[0].SetActive(true);
        for (int i = 0; i < Points2.Length; i++)
        {
            Points2[i].SetActive(false);
        }
        Points2[0].SetActive(true);
    }
    public void FanMode1()
    {
        int index=0;
        for (int i = 0; i < Backgrounds.Length; i++)
        {
            if (Backgrounds[i].activeSelf)
            {
                index = i;
                break;
            }
        }
        if (index == 0)
        {
            LevelPoint1++;
            if (LevelPoint1 == 4)
            {
                LevelPoint1 = 1;
            }
            for(int i = 0; i < Points1.Length; i++)
            {
                Points1[i].SetActive(false);
            }
            for (int i = 1; i <=LevelPoint1; i++)
            {
                Points1[i-1].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < Backgrounds.Length; i++)
            {
                Backgrounds[i].SetActive(false);
            }
            Backgrounds[0].SetActive(true);
        }

    }
    public void FanMode2()
    {
        int index=0;
        for (int i = 0; i < Backgrounds.Length; i++)
        {
            if (Backgrounds[i].activeSelf)
            {
                index = i;
                break;
            }
        }
        if (index == 1)
        {
            LevelPoint2++;
            if (LevelPoint2 == 4)
            {
                LevelPoint2 = 1;
            }
            for (int i = 0; i < Points2.Length; i++)
            {
                Points2[i].SetActive(false);
            }
            for (int i = 1; i <= LevelPoint2; i++)
            {
                Points2[i - 1].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < Backgrounds.Length; i++)
            {
                Backgrounds[i].SetActive(false);
            }
            Backgrounds[1].SetActive(true);
        }

    }
    public void FanMode3()
    {
        for (int i = 0; i < Backgrounds.Length; i++)
        {
            Backgrounds[i].SetActive(false);
        }
        Backgrounds[2].SetActive(true);

    }
}
