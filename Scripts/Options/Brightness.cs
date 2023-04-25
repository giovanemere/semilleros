using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public Slider slider;
    public float slidervalue;
    public Image brightnessPanel;
    private static float slidervalueglobal;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, slider.value);
    }
    public void ChangeSlider2(float value)
    {
        slidervalue = value;
        slidervalueglobal = (float) slider.value;
        PlayerPrefs.SetFloat("brillo", slidervalue);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, slider.value);
        Debug.Log(slidervalueglobal);
    }

}
