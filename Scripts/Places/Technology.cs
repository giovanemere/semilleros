using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Technology : MonoBehaviour
{
    public GameObject menuinterface,TechUpgradesInterface, PausePanel;
    public static bool isMenuActive,isTechInterfaceActive, isPauseActive, isOtherInterfaceActive;
    public Image brightnessPanel;
    public static bool[] isUpgradeApplied = { false, false, false, false, false };
    public static int[] UpgradePrice = { 10000, 15000, 20000, 50000, 100000 };
    public GameObject Cpus;
    public static bool isCpusOn;
    void Start()
    {
        UpdateBrightness();
        menuinterface.SetActive(false);
        TechUpgradesInterface.SetActive(false);
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
    }
    public void ShowMenu()
    {
        menuinterface.SetActive(true);
        TechUpgradesInterface.SetActive(false);
        PausePanel.SetActive(false);
        isMenuActive = true;
    }
    public void ShowTechInterface() 
    {
        TechUpgradesInterface.SetActive(true);
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        isTechInterfaceActive = true;
    }
    public void ShowPause()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        menuinterface.SetActive(false);
        TechUpgradesInterface.SetActive(false);
    }
    public void CloseAll()
    {
        menuinterface.SetActive(false);
        TechUpgradesInterface.SetActive(false);
        PausePanel.SetActive(false);
    }
    public void UpdateBrightness()
    {
        float brightness;
        brightness = PlayerPrefs.GetFloat("brillo", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightness);
    }
}
