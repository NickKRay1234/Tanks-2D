using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public float volume;
    public AudioMixer audioMixer;
    public Toggle _settingsToggle;
    public Slider _settingsSlider;
    public Image _settingsImage;


    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);

        if(volume > -80) _settingsImage.GetComponent<Image>().color = Color.green;
        else if(volume == -80) _settingsImage.GetComponent<Graphic>().color = Color.red;
    }

    public void ToggleChanged()
    {

        if(!_settingsToggle.isOn) 
        {
            _settingsImage.GetComponent<Image>().color = Color.green;
            _settingsSlider.value = -80f;
        } 
        if(_settingsToggle.isOn) 
        {
            _settingsImage.GetComponent<Graphic>().color = Color.red;
            _settingsSlider.value = 0f;
        }
    }


}
