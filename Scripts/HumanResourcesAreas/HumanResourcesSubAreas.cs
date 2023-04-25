using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HumanResourcesSubAreas : MonoBehaviour
{
    public Text security, productivity, securityPrice, happinessPrice,happiness;
    private int[] securityPrices = {1000, 5000, 10000, 15000, 20000, 25000, 30000, 35000, 40000, 45000};
    private int[] happinessPrices = { 20000, 18000, 16000, 14000, 12000, 10000, 8000, 6000, 4000, 2000 };
    private int randomVariable;
    void Start()
    {
        security.text = HumanResources.security.ToString();
        productivity.text = HumanResources.productivity.ToString();
        happiness.text = HumanResources.happiness.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        securityPrice.text = securityPrices[HumanResources.security].ToString();
        happinessPrice.text = happinessPrices[HumanResources.happiness].ToString();
        security.text = HumanResources.security.ToString();
        productivity.text = HumanResources.productivity.ToString();
        happiness.text = HumanResources.happiness.ToString();
    }
    public void FireEmployees()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        HumanResources.employeesList[ButtonReference.GetComponent<EmployessInfo>().ButtonID-1].IsActive = false;
        HumanResources.EmployeesCount();
    }
    public void UpgradeSecurity()
    {
        if (HumanResources.security<10 && Finances.capital >= securityPrices[HumanResources.security])
        {
            if ((Finances.capital - securityPrices[HumanResources.security]) <= Production.productsList[0].BuyingPrice )
            {

            }
            else
            {
                Finances.capital -= securityPrices[HumanResources.security];
                Finances.investedCapital += securityPrices[HumanResources.security];
                HumanResources.security += 1;
            }
        }
    }
    public void UpgradeHappiness()
    {
        if (HumanResources.happiness < 10 && Finances.capital >= happinessPrices[HumanResources.happiness])
        {
            if ((Finances.capital - happinessPrices[HumanResources.happiness]) <= Production.productsList[0].BuyingPrice)
            {

            }
            Finances.capital -= happinessPrices[HumanResources.happiness];
            Finances.investedCapital += happinessPrices[HumanResources.happiness];
            HumanResources.happiness += 1;
            if (HumanResources.productivity<10)
            {
                randomVariable = Random.Range(0, 6);
                if (randomVariable==0)
                {
                    HumanResources.productivity += 1;
                }
            }
        }
    }
    public void HiringPersonal()
    {
        if (Finances.capital>=HumanResources.employeesList[HumanResourcesButtons.EmployeeIndex].Salary && !HumanResources.employeesList[HumanResourcesButtons.EmployeeIndex].IsActive)
        {
            Finances.capital -= HumanResources.employeesList[HumanResourcesButtons.EmployeeIndex].Salary;
            Finances.investedCapital += HumanResources.employeesList[HumanResourcesButtons.EmployeeIndex].Salary;
            HumanResources.employeesList[HumanResourcesButtons.EmployeeIndex].IsActive = true;
            HumanResources.EmployeesCount();
        }
    }
}
