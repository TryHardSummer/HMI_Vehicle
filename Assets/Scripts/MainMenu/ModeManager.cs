using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class ModeManager : MonoBehaviour
{
    public GameObject t;
    public GameObject[] Points;
    public GameObject Ball;
    public GameObject[] Scenes;

    private TMP_Text Mode;
    private string[] Modes = { "CLIMATE", "SETTINGS", "CHARGE" };
    private Vector3 PointPos;
    private int GetNumberMode(string s)
    {
        for (int i = 0; i < 8; i++)
        {
            if (Modes[i].Equals(s))
            {
                return i;
            }
        }
        return 0;
    }
    public void BackMode()
    {
        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].SetActive(true);
        }
        Mode = t.GetComponent<TMP_Text>();
        string s = Mode.text;
        int index = GetNumberMode(s);
        Scenes[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = Modes.Length-1;
        }
        s = Modes[index];
        Mode.text = s;
        Vector3 PointPos = new Vector3(Points[index].transform.position.x, Points[index].transform.position.y, Points[index].transform.position.z);
        Ball.transform.position = PointPos;
        Scenes[index].SetActive(true);
    }
    void Start()
    {
        Mode = t.GetComponent<TMP_Text>();
        Mode.text = "CLIMATE";
        for(int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(false);
        }
        Scenes[0].SetActive(true);
    }

    public void NextMode()
    {
        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].SetActive(true);
        }
        Mode = t.GetComponent<TMP_Text>();
        string s = Mode.text;
        int index = GetNumberMode(s);
        Scenes[index].SetActive(false);
        index++;
        if (index == Modes.Length)
        {
            index = 0;
        }
        s = Modes[index];
        Mode.text = s;
        Vector3 PointPos = new Vector3(Points[index].transform.position.x, Points[index].transform.position.y, Points[index].transform.position.z);
        Ball.transform.position = PointPos;
        Points[index].SetActive(false);
        Scenes[index].SetActive(true);
    }
}
