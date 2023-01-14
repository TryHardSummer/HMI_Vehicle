using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HtmlAgilityPack;
using TMPro;
using UnityEngine.UI;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Threading.Tasks;

public class WeatherManager : MonoBehaviour
{
    public GameObject Location;
    public GameObject TypeOfWeather;
    public GameObject Temperatur;
    public GameObject TempBar;
    public GameObject[] Points;
    public GameObject Ball;
    public GameObject OtherBall;
    public GameObject Analog;
    public GameObject[] Visual;


    private string[] Cites = { "Izhevsk, Russia", "Tokyo, Japan", "New-York, USA", "Beijung, China", "Nur-Sultan, Kazahstan", "Moscow, Russia" };
    private int[] Urls = { 554840, 1850147, 5128581, 1816670, 1526273, 524901 };
    private int IndexCity = 0;
    private TMP_Text Loc;
    private TMP_Text Type;
    private TMP_Text Tem;
    private TMP_Text TemBar;
    private Image Vis;
    private RectTransform rect;

    void Start()
    {
        Loc = Location.GetComponent<TMP_Text>();
        Loc.text = Cites[IndexCity];
        OtherBall.SetActive(false);
        Analog.SetActive(false);
        ConnectAsync2(Urls[IndexCity]);
    }

    public void NextCity()
    {
        if (IndexCity == 5)
        {
            IndexCity = 0;
        }
        else
        {
            IndexCity++;
        }
        Loc=Location.GetComponent<TMP_Text>();
        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].SetActive(true);
        }
        if (IndexCity == 0)
        {
            OtherBall.SetActive(false);
            Ball.SetActive(true);
            Analog.SetActive(false);
        }
        else
        {
            Ball.SetActive(false);
            OtherBall.SetActive(true);
            Analog.SetActive(true);
            Vector3 PointPos = new Vector3(Points[IndexCity-1].transform.position.x, Points[IndexCity-1].transform.position.y, Points[IndexCity-1].transform.position.z);
            OtherBall.transform.position = PointPos;
            Points[IndexCity-1].SetActive(false);
        }
        ConnectAsync(Urls[IndexCity]);
        
    }

    private async Task ConnectAsync(int CountryID)
    {

        WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?id=" + CountryID + "&units=metric&APPID=510aa515af57309c7127070538e5766a");
        request.Method = "POST";
        WebResponse response = await request.GetResponseAsync();
        string answer = string.Empty;
        using (Stream s = response.GetResponseStream())
        {
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                answer = await reader.ReadToEndAsync();
            }
        }
        response.Close();
        WeatherResponse response_global = JsonConvert.DeserializeObject<WeatherResponse>(answer);
        string s1= Math.Round(response_global.main.temp, 1)+"°C";
        string s2= response_global.weather[0].main;
        Type= TypeOfWeather.GetComponent<TMP_Text>();
        Tem= Temperatur.GetComponent<TMP_Text>();
        Tem.text = s1;
        Type.text = s2;
        Loc.text = Cites[IndexCity];
        ChangeImage(s2);
    }

    private async Task ConnectAsync2(int CountryID)
    {

        WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?id=" + CountryID + "&units=metric&APPID=510aa515af57309c7127070538e5766a");
        request.Method = "POST";
        WebResponse response = await request.GetResponseAsync();
        string answer = string.Empty;
        using (Stream s = response.GetResponseStream())
        {
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                answer = await reader.ReadToEndAsync();
            }
        }
        response.Close();
        WeatherResponse response_global = JsonConvert.DeserializeObject<WeatherResponse>(answer);
        string s1 = Math.Round(response_global.main.temp, 1) + "°C";
        string s2 = response_global.weather[0].main;
        Type = TypeOfWeather.GetComponent<TMP_Text>();
        Tem = Temperatur.GetComponent<TMP_Text>();
        TemBar= TempBar.GetComponent<TMP_Text>();
        Tem.text = s1;
        TemBar.text = s1;
        Type.text = s2;
        Loc.text = Cites[IndexCity];
        ChangeImage(s2);
    }
    private void ChangeImage(string s)
    {
        if (s == "Clouds")
        {
            for(int i = 0; i < Visual.Length; i++)
            {
                Visual[i].SetActive(false);
            }
            Visual[0].SetActive(true);
        }
        else if (s == "Rain")
        {
            for (int i = 0; i < Visual.Length; i++)
            {
                Visual[i].SetActive(false);
            }
            Visual[1].SetActive(true);

        }
        else if (s == "Clear")
        {
            for (int i = 0; i < Visual.Length; i++)
            {
                Visual[i].SetActive(false);
            }
            Visual[2].SetActive(true);
        }
    }
    private class Temperature
    {
        public double temp;
    }

    private class WeatherNow
    {
        public string main;
        public string description;
    }

    private class WeatherResponse
    {
        public Temperature main;
        public string name;
        public WeatherNow[] weather;
    }


}
