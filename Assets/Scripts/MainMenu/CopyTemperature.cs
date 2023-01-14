using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CopyTemperature : MonoBehaviour
{
    public GameObject Main;
    public GameObject Example;

    private TMP_Text Tem;
    private TMP_Text Tem2;

    void Start()
    {
        Tem = Main.GetComponent<TMP_Text>();
        Tem2 = Example.GetComponent<TMP_Text>();
        Tem.text=Tem2.text;
    }

    // Update is called once per frame
    void Update()
    {
        Tem = Main.GetComponent<TMP_Text>();
        Tem2 = Example.GetComponent<TMP_Text>();
        Tem.text = Tem2.text;
    }
}
