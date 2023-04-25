using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseLogic : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject ControlsPanel;
    public GameObject SavePanel;

    void Start()
    {
        PausePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        SavePanel.SetActive(false);
    }

    void Update()
    {

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        SavePanel.SetActive(false);
        HumanResources.isPauseActive = false;
        Marketing.isPauseActive = false;
        HumanResources.isPauseActive = false;
        Production.isPauseActive = false;
        Technology.isPauseActive = false;
    }
    public void Save()
    {
        SavePanel.SetActive(true);
        ControlsPanel.SetActive(false);

    }
    public void BackMain()
    {
        HumanResources.isPauseActive = false;
        Marketing.isPauseActive = false;
        HumanResources.isPauseActive = false;
        Production.isPauseActive = false;
        Technology.isPauseActive = false;
        SceneManager.LoadScene("StartMenu");
    }
    public void GoOptions()
    {
        HumanResources.isPauseActive = false;
        Marketing.isPauseActive = false;
        HumanResources.isPauseActive = false;
        Production.isPauseActive = false;
        Technology.isPauseActive = false;
        SceneManager.LoadScene("Options");
    }
    public void GoTips()
    {
        //SceneManager.LoadScene("Tips");
    }
    public void Controls()
    {
        ControlsPanel.SetActive(true);
        PausePanel.SetActive(false);
    }
}
