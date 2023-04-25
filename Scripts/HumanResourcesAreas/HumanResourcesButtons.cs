using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanResourcesButtons : MonoBehaviour
{
    public GameObject SecurityPanel, happinessPanel, HiringPanel, Buttons;
    public Text _name, age, level, salary, area;
    private static bool employeeFound;
    private static int employeeIndex;
    public GameObject[] profileImages;
    void Start()
    {
        SecurityPanel.SetActive(false);
        happinessPanel.SetActive(false);
        HiringPanel.SetActive(false);
        for (int i = 0; i < 40; i++)
        {
            profileImages[i].SetActive(false);
        }
    }

    void Update()
    {
    }
    public void ActivateHiringPanel()
    {
        HiringPanel.SetActive(true);
        HumanResources.isOtherInterfaceActive = true;
        ShowEmployees();
    }
    public void CloseHiringPanel()
    {
        HiringPanel.SetActive(false);
    }
    public static int EmployeeIndex
    {
        get { return employeeIndex; }
        set { employeeIndex = value; }
    }

    public static bool EmployeeFound
    {
        get { return employeeFound; }
        set { employeeFound = value; }
    }


    void ShowEmployees()
    {
        while (!employeeFound)
        {
            employeeIndex = Random.Range(0, 40);
            if (!HumanResources.employeesList[employeeIndex].IsActive)
            {
                _name.text = HumanResources.employeesList[employeeIndex].Name.ToString();
                age.text = "Edad: " + HumanResources.employeesList[employeeIndex].Age.ToString();
                level.text = "Nivel: " + HumanResources.employeesList[employeeIndex].Level.ToString();
                salary.text = "Salario: " + HumanResources.employeesList[employeeIndex].Salary.ToString()+" /Mes";
                area.text = "Area: " + HumanResources.employeesList[employeeIndex].Area.ToString();
                profileImages[employeeIndex].SetActive(true);
                employeeFound = true;
            }
            else
            {
                employeeFound = false;
            }
        }
        if (employeeFound)
        {
            _name.text = HumanResources.employeesList[employeeIndex].Name.ToString();
            age.text = "Edad: " + HumanResources.employeesList[employeeIndex].Age.ToString();
            level.text = "Nivel: " + HumanResources.employeesList[employeeIndex].Level.ToString();
            salary.text = "Salario: " + HumanResources.employeesList[employeeIndex].Salary.ToString() + " /Mes";
            area.text = "Area: " + HumanResources.employeesList[employeeIndex].Area.ToString();
        }
    }
}

