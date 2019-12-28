using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playContentAudio : MonoBehaviour
{
    //音源AudioSource相当于播放器，而音效AudioClip相当于磁带
    private AudioSource music;

    //这里我要给主角添加播放的音效
    public AudioClip Audio_1;
    public AudioClip Audio_2;
    public AudioClip Audio_3;
    public AudioClip Audio_4;
    public AudioClip Audio_5;
    public AudioClip Audio_6;
    public AudioClip Audio_7;


    public static bool playContentMusic = false;

    private int ContentTime = 1;

    private int musicHasOver = 1;

    private void Awake()
    {
        //给对象添加一个AudioSource组件
        music = gameObject.AddComponent<AudioSource>();
        //设置不一开始就播放音效
        music.playOnAwake = false;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playContentMusic && ContentTime > 0)
        {
            if(GameController.number == 1)
            {
                music.clip = Audio_1;
                music.Play();
            }
            if (GameController.number == 2)
            {
                music.clip = Audio_2;
                music.Play();
            }
            if (GameController.number == 3)
            {
                music.clip = Audio_3;
                music.Play();
            }
            if (GameController.number == 4)
            {
                music.clip = Audio_4;
                music.Play();

            }
            if (GameController.number == 5)
            {
                music.clip = Audio_5;
                music.Play();
            }
            if (GameController.number == 6)
            {
                music.clip = Audio_6;
                music.Play();
            }
            if (GameController.number == 7)
            {
                music.clip = Audio_7;
                music.Play();
            }
            ContentTime--;
        }
    }
}
