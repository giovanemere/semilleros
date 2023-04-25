using UnityEngine;
using UnityEngine.UI;

public class Finances : MonoBehaviour
{
    public static float capital, pasiveIncome, lostCapital, profit, investedCapital;
    public GameObject financeinterface, menuinterface, PausePanel, mainInterface;
    public Text capitalText, lostCapitalText, profitText, investedCapitalText;
    public Image brightnessPanel;
    public static bool isInterfaceActive, isMenuActive, isPauseActive, isOtherInterfaceActive;
    void Start()
    {
        UpdateBrightness();    
        financeinterface.SetActive(false);
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        mainInterface.SetActive(true);
        isOtherInterfaceActive = false;
        Time.timeScale = 1f;
    }
    void Update()
    { 
        UpdateBrightness();
    }
    public void ShowInterface()
    {
        financeinterface.SetActive(true);
        isInterfaceActive = true;
        capitalText.text = capital.ToString();
        lostCapitalText.text = lostCapital.ToString();
        profitText.text = profit.ToString();
        investedCapitalText.text = investedCapital.ToString();
    }
    public void ShowMenu()
    {
        menuinterface.SetActive(true);
        isMenuActive = true;
        financeinterface.SetActive(false);
        isInterfaceActive = false;
    }
    public void ShowPause()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
    }
    public void UpdateBrightness()
    {
        float brightness;
        brightness = PlayerPrefs.GetFloat("brillo", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightness);
    }
    public void CloseInterfaces()
    {
        menuinterface.SetActive(false);
        isMenuActive = false;
        financeinterface.SetActive(false);
        isInterfaceActive = false;
        PausePanel.SetActive(false);
        isPauseActive = false;
        mainInterface.SetActive(true);
    }

}
