using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    private void Update()
    {
        GetScene();
        Debug.Log(PlayerManager.isInMainMenu);
    }

    public void Marketing()
    { 
        SceneManager.LoadScene("Marketing");
    }
    public void HumanResources()
    {
        SceneManager.LoadScene("HumanResources");   
    }
    public void Finances()
    {
        SceneManager.LoadScene("Finances");
    }
    public void Production()
    {
        SceneManager.LoadScene("Production");
    }
    public void Technology()
    {
        SceneManager.LoadScene("Technology");
    }
    public void GetScene() 
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Marketing":
                PlayerManager.isInMarketing = true;
                PlayerManager.isInFinances = false;
                PlayerManager.isInHumanResources = false;
                PlayerManager.isInProduction = false;
                PlayerManager.isInTechnology = false;
                PlayerManager.isInMainMenu = false;
                break;
            case "HumanResources":
                PlayerManager.isInMarketing = false;
                PlayerManager.isInFinances = false;
                PlayerManager.isInHumanResources = true;
                PlayerManager.isInProduction = false;
                PlayerManager.isInTechnology = false;
                PlayerManager.isInMainMenu = false;
                break;
            case "Finances":
                PlayerManager.isInMarketing = false;
                PlayerManager.isInFinances = true;
                PlayerManager.isInHumanResources = false;
                PlayerManager.isInProduction = false;
                PlayerManager.isInTechnology = false;
                PlayerManager.isInMainMenu = false;
                break;
            case "Production":
                PlayerManager.isInMarketing = false;
                PlayerManager.isInFinances = false;
                PlayerManager.isInHumanResources = false;
                PlayerManager.isInProduction = true;
                PlayerManager.isInTechnology = false;
                PlayerManager.isInMainMenu = false;
                break;
            case "Technology":
                PlayerManager.isInMarketing = false;
                PlayerManager.isInFinances = false;
                PlayerManager.isInHumanResources = false;
                PlayerManager.isInProduction = false;
                PlayerManager.isInTechnology = true;
                PlayerManager.isInMainMenu = false;
                break;
            case "StartMenu":
                PlayerManager.isInMarketing = false;
                PlayerManager.isInFinances = false;
                PlayerManager.isInHumanResources = false;
                PlayerManager.isInProduction = false;
                PlayerManager.isInTechnology = false;
                PlayerManager.isInMainMenu = true;
                Time.timeScale = 0f;
                break;
            default:
                break;
        }
    }
}
