using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using System;
using UnityEngine.EventSystems;


[RequireComponent(typeof(AudioSource))]

public class AudioManager : MonoBehaviour
{
    public AudioClip[] MusicList;
    public GameObject NameofSong;
    public GameObject Artist;
    public GameObject NowTimeofSong;
    public GameObject TimeofSong;
    public GameObject CoverObj;
    public Slider PB;
    

    private AudioSource source;
    private int currentTrack;
    private int RandomIndex=-1;
    private int SkipTrack = -1;
    private TMP_Text currentname;
    private TMP_Text currentartist;
    private TMP_Text currenttime;
    private TMP_Text currentalltime;
    private bool Repeat = false;
    private bool Random = false;
    private List<int> data = new List<int>();
    private Image Cover;

    void Start()
    {
        source = GetComponent<AudioSource>();
        PlayMusic();
    }

    IEnumerator WaitForMusicEnd()
    {
        int PlayTime;

        while (source.isPlaying)
        {
            PlayTime = (int)source.time;
            ShowTimeOfTrack(PlayTime);
            PB.maxValue = source.clip.length;
            PB.value = PlayTime;
            yield return null;
        }
        if (Repeat)
        {
            RepeatSong();
        }
        else
        {
            NextTrack();
        }
    }

    public void PlayMusic()
    {
        if (source.isPlaying)
        {
            return;
        }
        currentTrack--;
        if(currentTrack < 0)
        {
            currentTrack = MusicList.Length - 1;
        }
        StartCoroutine("WaitForMusicEnd");

    }

    public void NextTrack()
    {

        source.Stop();
        if (Random == true)
        {
            if (RandomIndex == -1)
            {
                GenerateRandomList();
                RandomIndex = 0;
                source.clip = MusicList[data[RandomIndex]];
                source.Play();
            }
            else
            {
                RandomIndex++;
                if (RandomIndex == MusicList.Length) {
                    RandomIndex = 0; 
                }
                source.clip = MusicList[data[RandomIndex]];
                source.Play();
            }
            ShowTitleOfTrack(data[RandomIndex] + 1);
        }
        else
        {
            currentTrack++;
            if (currentTrack > MusicList.Length - 1)
            {
                currentTrack = 0;
            }
            source.clip = MusicList[currentTrack];
            ShowTitleOfTrack(currentTrack+1);
            source.Play();
        }
        
        PB.value = 0;
        StartCoroutine("WaitForMusicEnd");
        
    }

    public void RepeatTrack()
    {
        Repeat = !Repeat;
    }

    public void RandomTrack()
    {
        if (Random == true)
        {
            Random = false;
            RandomIndex = -1;
            SkipTrack = -1;
        }
        else
        {
            Random = true;
            SkipTrack = currentTrack;
        }
        
    }

    public void BackTrack()
    {
        source.Stop();
        if (Random == true)
        {
            RandomIndex--;
            source.clip = MusicList[data[RandomIndex]];
            ShowTitleOfTrack(data[RandomIndex] + 1);
            source.Play();
        }
        else 
        {
            currentTrack--;
            if (currentTrack < 0)
            {
                currentTrack = MusicList.Length - 1;
            }
            source.clip = MusicList[currentTrack];
            ShowTitleOfTrack(currentTrack + 1);
            source.Play();
        }
        PB.value = 0;
        StartCoroutine("WaitForMusicEnd");
    }

    public void StopMusic(GameObject Replace)
    {
        if (source.isPlaying)
        {
            StopCoroutine("WaitForMusicEnd");
            source.Pause();
        }
        else
        {
            source.Play();
            StartCoroutine("WaitForMusicEnd");
        }
        Replace.SetActive(true);
    }

    public void Hide(GameObject Now)
    {
        Now.SetActive(false);
    }

    public void Show(GameObject Now)
    {
        Now.SetActive(true);
    }

    public void ChangeTime()
    {
        float NewTime = PB.value;
        source.time = NewTime;
        ShowTimeOfTrack((int)NewTime);
    }

    private void ShowTimeOfTrack(int time)
    {
        int sec = time % 60;
        int min = (time / 60) % 60;
        string res =min.ToString()+':'+sec.ToString("D2");
        currenttime = NowTimeofSong.GetComponent<TMP_Text>();
        currenttime.text = res;

        int timeUp = (int)source.clip.length-time;
        string resUp = "-"+((timeUp / 60) % 60) + ":" + (timeUp % 60).ToString("D2");
        currentalltime = TimeofSong.GetComponent<TMP_Text>();
        currentalltime.text = resUp;
    }
      
    private void ShowTitleOfTrack(int Index)
    {
        string nameCover = "cover" + (Index).ToString();
        Cover = CoverObj.GetComponent<Image>();
        Cover.sprite = Resources.Load<Sprite>(nameCover);


        string name = source.clip.name;
        currentname = NameofSong.GetComponent<TMP_Text>();
        currentartist = Artist.GetComponent<TMP_Text>();
        string[] g = Divide(name);
        currentname.text = g[0];
        currentartist.text = g[1];
    }

    private void GenerateRandomList()
    {
        System.Random rnd = new System.Random();
        for (int i = 0; i < MusicList.Length; i++)
        {
            if (SkipTrack == i)
            {
                continue;
            }
            data.Add(i);
        }
        for (int i = MusicList.Length - 1; i >= 0; i--)
        {
            int j = rnd.Next(i + 1);
            var temp = data[j];
            data[j] = data[i];
            data[i] = temp;
        }
    }

    private void RepeatSong()
    {
        StopCoroutine("WaitForMusicEnd");
        source.Stop();
        source.time = 0f;
        source.Play();
        StartCoroutine("WaitForMusicEnd");
    }

    private string[] Divide(string s)
    {
        int index = 0;
        string[] res = { "", "" };
        string h = "", t = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '!')
            {
                index = i;
                break;
            }
            else
            {
                h = h + s[i];
            }
        }
        for (int i = index + 1; i < s.Length; i++)
        {
            t = t + s[i];

        }
        res[0] = h;
        res[1] = t;
        return res;
    }

    
}
