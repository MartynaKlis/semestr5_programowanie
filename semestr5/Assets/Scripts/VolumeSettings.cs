using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public Slider SliderMusic;
    public Slider SliderSFX;
    public AudioMixer mainMixer;

    private void Start()
    {
        if (PlayerPrefs.HasKey("prefsMusicVolume"))
        {
            LoadPrefsVolume();
        }
        else 
        {
            SetMusicVolume();
            SetSFXVolume();
        }
    }


    public void SetMusicVolume()
    {
        float volumeMusic = SliderMusic.value;
        mainMixer.SetFloat("MusicVolume", Mathf.Log10(volumeMusic)*20);
        PlayerPrefs.SetFloat("prefsMusicVolume",volumeMusic);
    }

    public void SetSFXVolume()
    {
        float volumeSFX = SliderSFX.value;
        mainMixer.SetFloat("SFXVolume", Mathf.Log10(volumeSFX) * 20);
        PlayerPrefs.SetFloat("prefsSFXVolume", volumeSFX);
    }

    private void LoadPrefsVolume()
    {
        SliderMusic.value = PlayerPrefs.GetFloat("prefsMusicVolume");
        SliderSFX.value = PlayerPrefs.GetFloat("prefsSFXVolume");
    }
}

  
        
    

