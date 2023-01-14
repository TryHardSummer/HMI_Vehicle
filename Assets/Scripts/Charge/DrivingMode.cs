using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

public class DrivingMode : MonoBehaviour
{
    public GameObject[] Texts;

    public Sprite[] Backgrounds;
    public Sprite[] DockBoards;
    public Sprite[] Maps;
    public Sprite[] Weathers;
    public Sprite[] Powers;
    public Sprite[] Climates;
    public Sprite[] InClimates;
    public Sprite[] Settings;
    public Sprite[] Charges;
    public GameObject[] ModeText;
    public Sprite[] PicsInPower;
    public Sprite[] Players;


    public GameObject Background;
    public GameObject DockBoard;
    public GameObject Map;
    public GameObject Weather;
    public GameObject Power;
    public GameObject Climate;
    public GameObject InClimate;
    public GameObject Setting;
    public GameObject Charge;

    public GameObject PicInPower;
    public GameObject Player;

    private Image background;
    private Image dockBoard;
    private Image map;
    private Image weather;
    private Image power;
    private Image climate;
    private Image inClimate;
    private Image setting;
    private Image charge;
    private Image picInPower;
    private Image player;
    private TMP_Text text;
    void Start()
    {
        background = Background.GetComponent<Image>();
        background.sprite = Backgrounds[0];

        dockBoard = DockBoard.GetComponent<Image>();
        dockBoard.sprite = DockBoards[0];

        map = Map.GetComponent<Image>();
        map.sprite = Maps[0];

        weather = Weather.GetComponent<Image>();
        weather.sprite = Weathers[0];

        power = Power.GetComponent<Image>();
        power.sprite = Powers[0];

        climate = Climate.GetComponent<Image>();
        climate.sprite = Climates[0];

        inClimate = InClimate.GetComponent<Image>();
        inClimate.sprite = InClimates[0];

        setting = Setting.GetComponent<Image>();
        setting.sprite = Settings[0];

        charge = Charge.GetComponent<Image>();
        charge.sprite = Charges[0];

        picInPower = PicInPower.GetComponent<Image>();
        picInPower.sprite = PicsInPower[0];

        player = Player.GetComponent<Image>();
        player.sprite = Players[0];

        for(int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[0].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);

        for (int i = 0; i < ModeText.Length; i++)
        {
            ModeText[i].SetActive(false);
        }
        ModeText[0].SetActive(true);
}
    public void Eco()
    {
        background = Background.GetComponent<Image>();
        background.sprite = Backgrounds[0];

        dockBoard = DockBoard.GetComponent<Image>();
        dockBoard.sprite = DockBoards[0];

        map = Map.GetComponent<Image>();
        map.sprite = Maps[0];

        weather = Weather.GetComponent<Image>();
        weather.sprite = Weathers[0];

        power = Power.GetComponent<Image>();
        power.sprite = Powers[0];

        climate = Climate.GetComponent<Image>();
        climate.sprite = Climates[0];

        inClimate = InClimate.GetComponent<Image>();
        inClimate.sprite = InClimates[0];

        setting = Setting.GetComponent<Image>();
        setting.sprite = Settings[0];

        charge = Charge.GetComponent<Image>();
        charge.sprite = Charges[0];


        picInPower = PicInPower.GetComponent<Image>();
        picInPower.sprite = PicsInPower[0];

        player = Player.GetComponent<Image>();
        player.sprite = Players[0];

        for (int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[0].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
        for (int i = 0; i < ModeText.Length; i++)
        {
            ModeText[i].SetActive(false);
        }
        ModeText[0].SetActive(true);
    }

    public void Comfort()
    {
        background = Background.GetComponent<Image>();
        background.sprite = Backgrounds[1];

        dockBoard = DockBoard.GetComponent<Image>();
        dockBoard.sprite = DockBoards[1];

        map = Map.GetComponent<Image>();
        map.sprite = Maps[1];

        weather = Weather.GetComponent<Image>();
        weather.sprite = Weathers[1];

        power = Power.GetComponent<Image>();
        power.sprite = Powers[1];

        climate = Climate.GetComponent<Image>();
        climate.sprite = Climates[1];

        inClimate = InClimate.GetComponent<Image>();
        inClimate.sprite = InClimates[1];

        setting = Setting.GetComponent<Image>();
        setting.sprite = Settings[1];

        charge = Charge.GetComponent<Image>();
        charge.sprite = Charges[1];


        picInPower = PicInPower.GetComponent<Image>();
        picInPower.sprite = PicsInPower[1];

        player = Player.GetComponent<Image>();
        player.sprite = Players[1];

        for (int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[1].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
        for (int i = 0; i < ModeText.Length; i++)
        {
            ModeText[i].SetActive(false);
        }
        ModeText[1].SetActive(true);
    }

    public void Sport()
    {
        background = Background.GetComponent<Image>();
        background.sprite = Backgrounds[2];

        dockBoard = DockBoard.GetComponent<Image>();
        dockBoard.sprite = DockBoards[2];

        map = Map.GetComponent<Image>();
        map.sprite = Maps[2];

        weather = Weather.GetComponent<Image>();
        weather.sprite = Weathers[2];

        power = Power.GetComponent<Image>();
        power.sprite = Powers[2];

        climate = Climate.GetComponent<Image>();
        climate.sprite = Climates[2];

        inClimate = InClimate.GetComponent<Image>();
        inClimate.sprite = InClimates[2];

        setting = Setting.GetComponent<Image>();
        setting.sprite = Settings[2];

        charge = Charge.GetComponent<Image>();
        charge.sprite = Charges[2];


        picInPower = PicInPower.GetComponent<Image>();
        picInPower.sprite = PicsInPower[2];

        player = Player.GetComponent<Image>();
        player.sprite = Players[2];

        for (int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[2].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
        for (int i = 0; i < ModeText.Length; i++)
        {
            ModeText[i].SetActive(false);
        }
        ModeText[2].SetActive(true);
    }

    public void Turbo()
    {
        background = Background.GetComponent<Image>();
        background.sprite = Backgrounds[3];

        dockBoard = DockBoard.GetComponent<Image>();
        dockBoard.sprite = DockBoards[3];

        map = Map.GetComponent<Image>();
        map.sprite = Maps[3];

        weather = Weather.GetComponent<Image>();
        weather.sprite = Weathers[3];

        power = Power.GetComponent<Image>();
        power.sprite = Powers[3];

        climate = Climate.GetComponent<Image>();
        climate.sprite = Climates[3];

        inClimate = InClimate.GetComponent<Image>();
        inClimate.sprite = InClimates[3];

        setting = Setting.GetComponent<Image>();
        setting.sprite = Settings[3];

        charge = Charge.GetComponent<Image>();
        charge.sprite = Charges[3];


        picInPower = PicInPower.GetComponent<Image>();
        picInPower.sprite = PicsInPower[3];

        player = Player.GetComponent<Image>();
        player.sprite = Players[3];

        for (int i = 0; i < Texts.Length; i++)
        {
            text = Texts[i].GetComponent<TMP_Text>();
            text.color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1);
        }
        text = Texts[3].GetComponent<TMP_Text>();
        text.color = new Vector4(0 / 255.0f, 129 / 255.0f, 222 / 255.0f, 1);
        for (int i = 0; i < ModeText.Length; i++)
        {
            ModeText[i].SetActive(false);
        }
        ModeText[3].SetActive(true);
    }
}
