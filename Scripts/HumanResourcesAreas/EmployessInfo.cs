using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployessInfo : MonoBehaviour
{
    public int ButtonID;
    public Text NameText, SalaryText, AgeText, AreaText, LevelText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NameText.text = "Nombre: " + HumanResources.employeesList[ButtonID - 1].Name.ToString();
        SalaryText.text = "Salario:  " + HumanResources.employeesList[ButtonID - 1].Salary.ToString();
        AgeText.text = "Edad: " + HumanResources.employeesList[ButtonID - 1].Age.ToString();
        AreaText.text = "Area: " + HumanResources.employeesList[ButtonID - 1].Area.ToString();
        LevelText.text = "Nivel: "+ HumanResources.employeesList[ButtonID - 1].Level.ToString();
        HumanResources.EmployeesCount();
    }

}
