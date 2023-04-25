using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMarketing : MonoBehaviour
{
    public GameObject Cpus,tvon,tvoff;
    public static bool isCpusOn,isTvonOn,isTvoffOn,isanimated;
    public GameObject[] Employees;
    public static int employeesCount;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Employees.Length; i++)
        {
            Employees[i].SetActive(false);
        }
        if (QuestionsAndTips.tvon)
        {
            tvon.SetActive(true);
            tvoff.SetActive(false);
        }
        else { tvon.SetActive(false); tvoff.SetActive(true); }
        if (QuestionsAndTips.cpus)
        {
            Cpus.SetActive(true);
        }
        else
        {
            Cpus.SetActive(false);
        }
    }
    void Update()
    {
        if (QuestionsAndTips.tvon)
        {
            tvon.SetActive(true);
            tvoff.SetActive(false);
        }
        else { tvon.SetActive(false); tvoff.SetActive(true); }
        if (QuestionsAndTips.cpus)
        {
            Cpus.SetActive(true);
        }
        else
        {
            Cpus.SetActive(false);
        }
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
            if (HumanResources.employeesList[i].IsActive && HumanResources.employeesList[i].Area == "Marketing")
            {
                employeesCount += 1;
                Debug.Log("entro" + HumanResources.employeesList[i].IsActive+ HumanResources.employeesList[i].Name);

            }
        }
    }

}
