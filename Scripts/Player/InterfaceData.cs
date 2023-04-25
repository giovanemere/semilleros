using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceData : MonoBehaviour
{
    public static float capital,pasiveIncome;
    public static int employees, customers, products;
    public Text CapText, employText, customText, productText;

    void Start()
    {
        
    }

    void Update()
    {
        InterfaceText();
        capital = Finances.capital;
        Production.GetTotalProducts();
        products = Production.products;
        Debug.Log(capital);
    }
    void InterfaceText()
    {
        CapText.text = capital.ToString();
        employText.text = employees.ToString();
        customText.text = customers.ToString();
        productText.text = products.ToString();
    }
}
