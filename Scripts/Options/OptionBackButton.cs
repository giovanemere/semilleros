using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionBackButton : MonoBehaviour
{
    void Start()
    {

    }
    public void BackMain()
    {
        if (PlayerManager.isInMainMenu)
        {
            SceneManager.LoadScene("StartMenu");
        }
        if (PlayerManager.isInFinances)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Finances");
        }
        if (PlayerManager.isInHumanResources)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("HumanResources");
        }
        if (PlayerManager.isInMarketing)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Marketing");
        }
        if (PlayerManager.isInProduction)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Production");
        }
        if (PlayerManager.isInTechnology)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Technology");
        }
        

    }
}
