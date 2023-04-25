using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsLogic : MonoBehaviour
{
    public static bool isGameLoaded;
    public GameObject controlsPanel, achievementsPanel, StartPanel, newGamePanel;
    public Button noButton;
    public Image brightnessPanel;
    public Text playerDisplay;
    void Start()
    {
        controlsPanel.SetActive(false);
        achievementsPanel.SetActive(false);
        StartPanel.SetActive(true);
        newGamePanel.SetActive(false);
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.username;
        }
    }
    public void ShowOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void Scene1Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void MainMenu()
    {
        controlsPanel.SetActive(false);
        achievementsPanel.SetActive(false);
        StartPanel.SetActive(true);
        newGamePanel.SetActive(false);
    }

    public void Controls()
    {
        controlsPanel.SetActive(true);
        achievementsPanel.SetActive(false);
        StartPanel.SetActive(false);
        newGamePanel.SetActive(false);
    }
    public void Achievements()
    {
        controlsPanel.SetActive(false);
        achievementsPanel.SetActive(true);
        StartPanel.SetActive(false);
        newGamePanel.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void BackMain()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void GoOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void Play()
    {
        StartPanel.SetActive(true);
        controlsPanel.SetActive(false);
        achievementsPanel.SetActive(false);
        newGamePanel.SetActive(true);
    }
    public void loadScene()
    {
        Time.timeScale = 1f;
        isGameLoaded = true;
        SceneManager.LoadScene("Video");
    }
    public void NoloadScene()
    {
        isGameLoaded = false;
        SceneManager.LoadScene("Finances");
    }

    public void brillo()
    {
        float ella;
        ella = PlayerPrefs.GetFloat("brillo", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, ella);
        Debug.Log(ella);
    }

    void Update()
    {
        brillo();
    }

}
