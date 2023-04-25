using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanResources : MonoBehaviour
{
    public GameObject menuinterface, PausePanel,employeesInterface,GeneralInterface,SecurityPanel, HappinessPanel;
    public static bool isMenuActive, isPauseActive, isEmployeesInterfaceActive,isOtherInterfaceActive,isGeneralActive;
    public static int happiness, security, productivity;
    public Image brightnessPanel;
    public static List<Employees> employeesList = new List<Employees>();
    public GameObject[] employees;
    //public GameObject[] profileImages;
    

    void Start()
    {
        UpdateBrightness();
        if (InterfaceData.employees==0)
        {
            employeesList = InitializeEmployees(employeesList);
        }
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        employeesInterface.SetActive(false);
        GeneralInterface.SetActive(false);
        SecurityPanel.SetActive(false);
        HappinessPanel.SetActive(false);
        isEmployeesInterfaceActive = false;
        isMenuActive = false;
        isPauseActive = false;
        isGeneralActive = false;
        Time.timeScale = 1f;
    }

    void Update(){
    }

    public void ShowMenu()
    {
        menuinterface.SetActive(true);
        PausePanel.SetActive(false);
        employeesInterface.SetActive(false);
        GeneralInterface.SetActive(false);
        SecurityPanel.SetActive(false);
        HappinessPanel.SetActive(false);
        isMenuActive = true;
        isGeneralActive = false;
    }
    public void ShowPause()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        menuinterface.SetActive(false);
        employeesInterface.SetActive(false);
        GeneralInterface.SetActive(false);
        SecurityPanel.SetActive(false);
        HappinessPanel.SetActive(false);
        isGeneralActive = false;

    }
    public void showEmployessInterface()
    {
        EmployeesList();
        employeesInterface.SetActive(true);
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        GeneralInterface.SetActive(false);
        SecurityPanel.SetActive(false);
        HappinessPanel.SetActive(false);
        isEmployeesInterfaceActive = true;
        isGeneralActive = false;
    }
    public void CloseInterfaces()
    {
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        employeesInterface.SetActive(false);
        GeneralInterface.SetActive(false);
        SecurityPanel.SetActive(false);
        HappinessPanel.SetActive(false);
        isGeneralActive = false;
    }
    public void ShowHappinessInterface()
    {
        if (!isGeneralActive)
        {
            GeneralInterface.SetActive(true);
            isGeneralActive = true;
        }
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        employeesInterface.SetActive(false);
        SecurityPanel.SetActive(false);
        HappinessPanel.SetActive(true);
    }
    public void ShowHiringPanel()
    {
        if (!isGeneralActive)
        {
            GeneralInterface.SetActive(true);
            isGeneralActive = true;
        }
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        employeesInterface.SetActive(false);
        SecurityPanel.SetActive(false);
        HappinessPanel.SetActive(false);
    }
    public void ShowSecurityPanel()
    {
        if (!isGeneralActive)
        {
            GeneralInterface.SetActive(true);
            isGeneralActive = true;
        }
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        employeesInterface.SetActive(false);
        SecurityPanel.SetActive(true);
        HappinessPanel.SetActive(false);
    }
    List<Employees> InitializeEmployees(List<Employees> employeesList)
    {
        employeesList = new List<Employees>() {
                new Employees(){Age=35,Level=0,Name="Ariadna",Area="Producción",IsActive=false,Salary=150},
                new Employees(){Age=27,Level=0,Name="Luisa",Area="Producción",IsActive=false,Salary=150},
                new Employees(){Age=20,Level=0,Name="Oscar",Area="Finanzas",IsActive=false,Salary=50},
                new Employees(){Age=22,Level=0,Name="Veronica",Area="Marketing",IsActive=false,Salary=100},
                new Employees(){Age=23,Level=0,Name="Ismael",Area="human",IsActive=false,Salary=50},
                new Employees(){Age=24,Level=0,Name="Peter",Area="Recursos Humanos",IsActive=false,Salary=100},
                new Employees(){Age=25,Level=0,Name="Eva",Area="Marketing",IsActive=false,Salary=100},
                new Employees(){Age=26,Level=0,Name="Luis",Area="Recursos Humanos",IsActive=false,Salary=100},
                new Employees(){Age=27,Level=1,Name="Cristina",Area="Recursos Humanos",IsActive=false,Salary=200},
                new Employees(){Age=28,Level=1,Name="Alda",Area="Tecnologia",IsActive=false,Salary=150},
                new Employees(){Age=29,Level=1,Name="Dante",Area="Finanzas",IsActive=false,Salary=150},
                new Employees(){Age=27,Level=1,Name="Lesly",Area="Tecnologia",IsActive=false,Salary=150},
                new Employees(){Age=28,Level=1,Name="Augustin",Area="Marketing",IsActive=false,Salary=200},
                new Employees(){Age=29,Level=1,Name="Dylan",Area="Marketing",IsActive=false,Salary=200},
                new Employees(){Age=27,Level=1,Name="Michelle",Area="Producción",IsActive=false,Salary=300},
                new Employees(){Age=28,Level=1,Name="Anne",Area="Producción",IsActive=false,Salary=300},
                new Employees(){Age=29,Level=1,Name="Josue",Area="Recursos Humanos",IsActive=false,Salary=200},
                new Employees(){Age=28,Level=1,Name="Violeta",Area="Finanzas",IsActive=false,Salary=150},
                new Employees(){Age=27,Level=1,Name="Natalie",Area="Finanzas",IsActive=false,Salary=150},
                new Employees(){Age=26,Level=2,Name="Felipe",Area="Finanzas",IsActive=false,Salary=350},
                new Employees(){Age=25,Level=2,Name="Rosseta",Area="Marketing",IsActive=false,Salary=400},
                new Employees(){Age=24,Level=2,Name="Sebastian",Area="Tecnologia",IsActive=false,Salary=350},
                new Employees(){Age=23,Level=2,Name="Stella",Area="Recursos Humanos",IsActive=false,Salary=350},
                new Employees(){Age=24,Level=2,Name="Wendi",Area="Producción",IsActive=false,Salary=550},
                new Employees(){Age=25,Level=2,Name="Adrian",Area="Finanzas",IsActive=false,Salary=350},
                new Employees(){Age=22,Level=2,Name="Isaac",Area="Marketing",IsActive=false,Salary=400},
                new Employees(){Age=21,Level=2,Name="Mark",Area="Tecnologia",IsActive=false,Salary=350},
                new Employees(){Age=22,Level=2,Name="Patricio",Area="Recursos Humanos",IsActive=false,Salary=350},
                new Employees(){Age=22,Level=2,Name="Perlita",Area="Producción",IsActive=false,Salary=550},
                new Employees(){Age=29,Level=2,Name="Gustavo",Area="Finanzas",IsActive=false,Salary=350},
                new Employees(){Age=21,Level=2,Name="Fabian",Area="Tecnologia",IsActive=false,Salary=350},
                new Employees(){Age=28,Level=2,Name="Carmen",Area="Producción",IsActive=false,Salary=550},
                new Employees(){Age=26,Level=3,Name="Maribel",Area="Finanzas",IsActive=false,Salary=700},
                new Employees(){Age=24,Level=3,Name="Juanita",Area="Marketing",IsActive=false,Salary=500},
                new Employees(){Age=27,Level=3,Name="Isabel",Area="Tecnologia",IsActive=false,Salary=450},
                new Employees(){Age=29,Level=3,Name="Elise",Area="Recursos Humanos",IsActive=false,Salary=500},
                new Employees(){Age=29,Level=3,Name="Elisabeth",Area="Producción",IsActive=false,Salary=600},
                new Employees(){Age=29,Level=3,Name="Merlin",Area="Marketing",IsActive=false,Salary=500},
                new Employees(){Age=29,Level=3,Name="Luca",Area="Tecnologia",IsActive=false,Salary=450},
                new Employees(){Age=29,Level=3,Name="Ethan",Area="Recursos Humanos",IsActive=false,Salary=500}
            };
        return employeesList;
    }
    public void UpdateBrightness()
    {
        float brightness;
        brightness = PlayerPrefs.GetFloat("brillo", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightness);
    }

    public void EmployeesList()
    {
        for (int i = 0; i < 40; i++)
        {
            if (HumanResources.employeesList[i].IsActive)
            {
                employees[i].SetActive(true);
            }
            else
            {
                employees[i].SetActive(false);
            }
        }
    }
    public static void EmployeesCount()
    {
        InterfaceData.employees = 0;
        for (int i = 0; i < HumanResources.employeesList.Count; i++)
        {
            if (HumanResources.employeesList[i].IsActive)
            {
                InterfaceData.employees += 1;
            }
        }
    }
}
