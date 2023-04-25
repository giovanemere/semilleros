using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerManager : MonoBehaviour
{
    public float capital,pasiveIncome;
    public static int employees, customers,products;
    public static bool isInMarketing, isInHumanResources, isInFinances, isInProduction, isInTechnology, isInMainMenu;
    public static bool isSold, canSell,canShowQuestion, canShowTip,firstTime, wasOnTutorial,isprods;
    public static int timeProducts; // tiempo en verder cara producto
    public static int questionCounter, tipsCounter, score,random;
    private static bool created = false;

    //InGame Time
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;
    public static int Minute { get; private set; }
    public static int Hour { get; private set; }
    public static int Day { get; private set; }
    public static int Month { get; private set; }
    public static int Year { get; private set; }

    private float minuteToRealTime = 0.7f;//0.7
    private float timer;

    private void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        DontDestroyOnLoad(this);
        if (!firstTime)
        {
            Minute = 50;
            Hour = 7;
            Month = 1;
            Day = 1;
            Year = 1;
            firstTime = true;
        }
        timer = 0;
        timer = minuteToRealTime;
        isInMainMenu = true;
        canSell = true;
    }

    void Update()
    {
        capital = InterfaceData.capital;
        pasiveIncome = InterfaceData.pasiveIncome;
        employees = InterfaceData.employees;
        customers = InterfaceData.customers;
        products = InterfaceData.products;
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Minute++;
            OnMinuteChanged?.Invoke();
            if (Minute >= 60)
            {
                Hour++;
                Minute = 0;
            }
            else if (Hour>=24)
            {
                Day++;
                Hour = 0;
            }
            else if (Day>=30)
            {
                Month++;
                //pagar salarios
                //condicional si no tiene dinero
                for (int i = 0; i < HumanResources.employeesList.Count; i++)
                {
                    if (HumanResources.employeesList[i].IsActive)
                    {
                        Finances.capital -= HumanResources.employeesList[i].Salary;
                        Finances.investedCapital += HumanResources.employeesList[i].Salary;
                    }
                }
                Day = 1;
            }
            else if (Month>=12)
            {
                Year++;
                Month = 1;
            }
            if (QuestionsAndTips.pasardias)
            {
                Day += 3;
                QuestionsAndTips.pasardias = false;
            }
            timer = minuteToRealTime;
        }
        //Vender productos
        if (products > 0 && Minute % 6 == 0 && canSell)
        {
            if (!isSold)
            {
                Production.SellProducts();
                isSold = true;
                InterfaceData.customers += 1;
            }

        }
        else
        {
            isSold = false;
        }
        //resetear hojas de vida empleado
        if (Hour==12)
        {
            HumanResourcesButtons.EmployeeFound = false;
        }
        //pasar noche rapido
        if (Hour == 20)
        {
            minuteToRealTime = 0.2f;//0-2
            canSell = false;
        }
        if (Hour==6)
        {
            //minuteToRealTime = 0.7f;//0,7
            canSell = true;
        }
        //Tips
        if (Hour == 8 && Minute==0 && wasOnTutorial)
        {
            canShowTip = true;
            
        }
        //Questions
        if (Hour == 9 && Minute==0 && wasOnTutorial)
        {
            canShowQuestion = true;
        }
        //para tests
        /*if (Hour==9 && Minute == 10)
        {
            Hour = 7;
            Minute = 50;
        }*/
        //Perder por capital
        if (products==0)
        {
            if (capital <= Production.productsList[0].BuyingPrice && wasOnTutorial)
            {
                TextoGameover.iscapitalgameover = true;
                SceneManager.LoadScene("GameOver");
            }
            
        }
        /*if (products == 0 && wasOnTutorial )
        {
            if (Finances.capital<Production.productsList[0].BuyingPrice)
            {
                TextoGameover.iscapitalgameover = true;
                SceneManager.LoadScene("GameOver");
            }
        }*/
        if (Input.GetKeyDown(KeyCode.P))
        {
            minuteToRealTime = 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Hour = 5;
            Minute = 59;
            Day += 1;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            minuteToRealTime = 0.7f;
        }
        Debug.Log(wasOnTutorial);
    }
}
