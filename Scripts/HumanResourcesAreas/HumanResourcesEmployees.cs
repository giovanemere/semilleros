using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanResourcesEmployees : MonoBehaviour
{
    public static GameObject[] employees;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void EmployeesList()
    {
        for (int i = 0; i < HumanResources.employeesList.Count; i++)
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
}
