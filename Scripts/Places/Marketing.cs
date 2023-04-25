using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marketing : MonoBehaviour
{
    public GameObject menuinterface, PausePanel;
    public static bool isMenuActive, isPauseActive, isOtherInterfaceActive;
    public Image brightnessPanel;
    

    void Start()
    {
        UpdateBrightness();
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        isMenuActive = false;
        isPauseActive = false;
        isOtherInterfaceActive = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
    }
    public void ShowMenu()
    {
        menuinterface.SetActive(true);
        PausePanel.SetActive(false);
        isMenuActive = true;
    }
    public void ShowPause()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        menuinterface.SetActive(false);
    }
   public void CloseAll()
    {
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
    }
    public void UpdateBrightness()
    {
        float brightness;
        brightness = PlayerPrefs.GetFloat("brillo", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightness);
    }
}
