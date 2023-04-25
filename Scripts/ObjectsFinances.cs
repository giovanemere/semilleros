using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsFinances : MonoBehaviour
{
    public GameObject[] Employees;
    public static int employeesCount;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Employees.Length; i++)
        {
            Employees[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        NumberofEmployees();
        for (int i = 0; i < employeesCount; i++)
        {
            Employees[i].SetActive(true);
        }
        Debug.Log(employeesCount);
    }
    public void NumberofEmployees()
    {
        employeesCount = 0;
        for (int i = 0; i < HumanResources.employeesList.Count; i++)
        {
            if (HumanResources.employeesList[i].IsActive && HumanResources.employeesList[i].Area == "Finanzas")
            {
                employeesCount += 1;
                Debug.Log("entro" + HumanResources.employeesList[i].IsActive + HumanResources.employeesList[i].Name);
            }
        }
    }
}
