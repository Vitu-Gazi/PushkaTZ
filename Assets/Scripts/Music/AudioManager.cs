using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private Image soundImage;
    [SerializeField] private Sprite soundOn;
    [SerializeField] private Sprite soundOff;

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Audio") == null)
        {
            DontDestroyOnLoad(Instantiate(obj));
        }

        ChangeImage();
    }


    public void ChangeSoundVolume ()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }

        ChangeImage();
    }

    private void ChangeImage()
    {
        if (AudioListener.volume == 0)
        {
            soundImage.sprite = soundOff;
        }
        else
        {
            soundImage.sprite = soundOn;
        }
    }
}
