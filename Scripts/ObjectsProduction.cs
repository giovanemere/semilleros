using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsProduction : MonoBehaviour
{
    public GameObject[] Breads;
    public GameObject BreadsBox,breaddesk1,breaddesk2,register,box;
    public GameObject[] Employees;
    public static int employeesCount,breadcount;
    public static bool showBreadBox, animatebreads;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Employees.Length; i++)
        {
            Employees[i].SetActive(false);
        }
        if (InterfaceData.products>0)
        {
            BreadsBox.SetActive(true);
            showBreadBox = true;
            animatebreads = true;
        }
        else
        {
            BreadsBox.SetActive(false);
            showBreadBox = false;
            animatebreads = false;
        }
        if (QuestionsAndTips.degustaciones)
        {
            breaddesk1.SetActive(true);
            breaddesk2.SetActive(true);
        }
        else
        {
            breaddesk1.SetActive(false);
            breaddesk2.SetActive(false);
        }
        if (QuestionsAndTips.registradora)
        {
            register.SetActive(true);
        }
        else
        {
            register.SetActive(false);
        }
        if (QuestionsAndTips.cajatrigo)
        {
            box.SetActive(true);
        }
        else
        {
            box.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (InterfaceData.products > 0)
        {
            BreadsBox.SetActive(true);
            showBreadBox = true;
            animatebreads = true;
        }
        else
        {
            BreadsBox.SetActive(false);
            showBreadBox = false;
            animatebreads = false;
            breadcount = 0;
        }
        if (QuestionsAndTips.degustaciones)
        {
            breaddesk1.SetActive(true);
            breaddesk2.SetActive(true);
        }
        else
        {
            breaddesk1.SetActive(false);
            breaddesk2.SetActive(false);
        }
        if (QuestionsAndTips.registradora)
        {
            register.SetActive(true);
        }
        else
        {
            register.SetActive(false);
        }
        if (QuestionsAndTips.cajatrigo)
        {
            box.SetActive(true);
        }
        else
        {
            box.SetActive(false);
        }
        NumberofEmployees();
        for (int i = 0; i < employeesCount; i++)
        {
            Employees[i].SetActive(true);
        }
        Debug.Log(employeesCount);
        if (animatebreads)
        {
            Invoke("ShowBreads", 3f);
        }
    }
    public void NumberofEmployees()
    {
        employeesCount = 0;
        for (int i = 0; i < HumanResources.employeesList.Count; i++)
        {
            if (HumanResources.employeesList[i].IsActive && HumanResources.employeesList[i].Area == "Producción")
            {
                employeesCount += 1;
                Debug.Log("entro" + HumanResources.employeesList[i].IsActive + HumanResources.employeesList[i].Name);
            }
        }
    }
    public void ShowBreads()
    {
        if (breadcount<7)
        {
            breadcount += 1;
            Debug.Log(breadcount);
        }
        else
        {
            breadcount = 0;
        }
    }
}
