using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionsAndTips : MonoBehaviour
{
    public GameObject[] Questions, Tips;
    public Image notification;
    public bool isActive,isintermediateTip;
    public static int[] evaluate = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static int counter,salary,indexEmployee,tipcounter;
    public GameObject Peoplestreet, happy, sad, murmurs, people, marketing,police,nature,disturbs;
    public static bool degustaciones, servidores, policia, cajaprodcerrada,pasardias,tvon,registradora,cajatrigo,compus,cpus;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Questions.Length; i++)
        {
            Questions[i].SetActive(false);
        }
        for (int i = 0; i < Tips.Length; i++)
        {
            Tips[i].SetActive(false);
        }
        notification.enabled = false;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

        QuestionsLogic();
        if (PlayerManager.canShowTip)
        {
            notification.enabled = true;
            PlayerManager.tipsCounter = tipcounter;

        }
        Debug.Log(PlayerManager.score+" "+PlayerManager.questionCounter+" "+counter);
        Debug.Log("S"+HumanResources.security);
        Debug.Log("P"+HumanResources.productivity);
        Debug.Log("H"+HumanResources.happiness);
        Debug.Log("C" + Clients.likeProbability);
    }
    public void TipsLogic()
    {
        if (PlayerManager.canShowTip)
        {
            PlayerManager.canShowTip = false;
        }
        if (isActive)
        {
            for (int i = 0; i < 22; i++)
            {
                Tips[i].SetActive(false);
            }
            isActive = false;
        }
        else
        {
            Tips[tipcounter].SetActive(true);
            notification.enabled = false;
            isActive = true;
        }
        

    }
    public void QuestionsLogic()
    {
        if (PlayerManager.canShowQuestion && PlayerManager.questionCounter<23)
        {
            Finances.isOtherInterfaceActive = true;
            Marketing.isOtherInterfaceActive = true;
            HumanResources.isOtherInterfaceActive = true;
            Technology.isOtherInterfaceActive = true;
            Production.isOtherInterfaceActive = true;
            Questions[PlayerManager.questionCounter].SetActive(true);
            //A
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Questions[PlayerManager.questionCounter].SetActive(false);
                switch (PlayerManager.questionCounter)
                {
                    case 0:
                        tipcounter = 2;
                        PlayerManager.tipsCounter = 1;
                        PlayerManager.score += 10;
                        Clients.likeProbability = 3;
                        evaluate[counter] = 1;
                        counter += 1;
                        Instantiate(Peoplestreet);
                        SceneManager.LoadScene("HumanResources");
                        break;
                    case 1:
                        tipcounter = 3;
                        PlayerManager.score += 10;
                        HumanResources.employeesList[14].IsActive = true;
                        HumanResources.employeesList[15].IsActive = true;
                        HumanResources.employeesList[2].IsActive = true;
                        HumanResources.EmployeesCount();
                        evaluate[counter] = 1;
                        counter += 1;
                        SceneManager.LoadScene("Production");
                        break;
                    case 2:
                        tipcounter = 4;
                        PlayerManager.score += 10;
                        //Retroalimentacion
                        evaluate[counter] = 1;
                        counter += 1;
                        Finances.capital -= 10000;
                        Finances.investedCapital += 10000;
                        Production.productsList[0].Amount = 100;
                        InterfaceData.products = Production.productsList[0].Amount;
                        SceneManager.LoadScene("Marketing");
                        break;
                    case 3:
                        tipcounter = 5;
                        PlayerManager.score += 10;
                        //Retroalimentacion
                        Clients.likeProbability +=1;
                        evaluate[counter] = 1;
                        counter += 1;
                        Instantiate(murmurs);
                        SceneManager.LoadScene("Technology");
                        break;
                    case 4:
                        tipcounter = 6;
                        PlayerManager.questionCounter = 7;
                        //No afecta
                        evaluate[counter] = 2;
                        counter += 1;
                        PlayerManager.wasOnTutorial = true;
                        SceneManager.LoadScene("Finances");
                        break;
                    case 5:
                        tipcounter = 7;
                        PlayerManager.score += 10;
                        HumanResources.productivity += 2;
                        HumanResources.security += 1;
                        HumanResources.happiness += 1;
                        evaluate[counter] = 1;
                        counter += 1;
                        Instantiate(people);
                        break;
                    case 6:
                        //notip
                        PlayerManager.questionCounter = 7;
                        //retroalimentacion y desbloquear cupcake
                        evaluate[counter] = 2;
                        counter += 1;
                        break;
                    case 7:
                        //notip
                        PlayerManager.questionCounter = 9;
                        HumanResources.productivity += 1;
                        HumanResources.happiness -= 2;
                        evaluate[counter] = 2;
                        counter += 1;
                        Instantiate(people);
                        break;
                    case 8:
                        //notip
                        PlayerManager.questionCounter = 9;
                        PlayerManager.score += 10;
                        HumanResources.happiness += 1;
                        for (int i = 0; i < 40; i++)
                        {
                            if (HumanResources.employeesList[i].Area == "Producción" && !HumanResources.employeesList[i].IsActive)
                            {
                                HumanResources.employeesList[i].IsActive = true;
                                indexEmployee = i;
                                break;
                            }
                        }
                        HumanResources.EmployeesCount();
                        evaluate[counter] = 1;
                        counter += 1;
                        Instantiate(happy);
                        break;
                    case 9:
                        //notip
                        PlayerManager.questionCounter = 7;
                        HumanResources.employeesList[indexEmployee].IsActive = false;
                        HumanResources.EmployeesCount();
                        evaluate[counter] = 2;
                        counter += 1;
                        Instantiate(sad);
                        break;
                    case 10:
                        tipcounter = 11;
                        Clients.likeProbability += 1;
                        evaluate[counter] = 2;
                        counter += 1;
                        degustaciones = true;
                        break;
                    case 11:
                        tipcounter = 16;
                        PlayerManager.score += 10;
                        PlayerManager.questionCounter = 15;
                        Finances.capital -= 15000;
                        Finances.investedCapital += 15000;
                        HumanResources.security = 2;
                        HumanResources.happiness += 1;
                        evaluate[counter] = 1;
                        counter += 1;
                        servidores = true;
                        break;
                    case 12:
                        tipcounter = 16;
                        PlayerManager.questionCounter = 15;
                        PlayerManager.score += 10;
                        HumanResources.security += 2;
                        for (int i = 0; i < 40; i++)
                        {
                            if (HumanResources.employeesList[i].Area=="Producción" && HumanResources.employeesList[i].IsActive)
                            {
                                HumanResources.employeesList[i].IsActive = false;
                                Finances.capital -= HumanResources.employeesList[i].Salary;
                                break;
                            }
                        }
                        HumanResources.EmployeesCount();
                        evaluate[counter] = 1;
                        counter += 1;
                        Instantiate(police);
                        break;
                    case 13:
                        tipcounter = 16;
                        PlayerManager.score += 10;
                        HumanResources.security += 2;
                        for (int i = 0; i < HumanResources.employeesList.Count; i++)
                        {
                            if (HumanResources.employeesList[i].Area == "Producción" && HumanResources.employeesList[i].IsActive)
                            {
                                HumanResources.employeesList[i].IsActive = false;
                                Finances.capital -= HumanResources.employeesList[i].Salary;
                                break;
                            }
                        }
                        HumanResources.EmployeesCount();
                        evaluate[counter] = 1;
                        counter += 1;
                        Instantiate(police);
                        break;
                    case 14:
                        tipcounter = 15;
                        HumanResources.security += 4;
                        pasardias = true;
                        //Aumentar dias
                        evaluate[counter] = 2;
                        counter += 1;
                        break;
                    case 15:
                        tipcounter = 16;
                        PlayerManager.score += 10;
                        Clients.likeProbability += 1;
                        evaluate[counter] = 2;
                        counter += 1;
                        break;
                    case 16:
                        tipcounter = 18;
                        PlayerManager.score += 10;
                        Finances.capital -= 5000;
                        evaluate[counter] = 1;
                        counter += 1;
                        cajaprodcerrada = true;

                        break;
                    case 17:
                        tipcounter = 19;
                        evaluate[counter] = 2;
                        counter += 1;
                        Instantiate(marketing);
                        //noafecta
                        break;
                    case 18:
                        tipcounter = 20;
                        Finances.capital -= 15000;
                        Finances.investedCapital += 15000;
                        HumanResources.productivity += 3;
                        evaluate[counter] = 2;
                        counter += 1;
                        Instantiate(happy);
                        break;
                    case 19:
                        //notip
                        Finances.capital -= 7000;
                        Finances.investedCapital += 7000;
                        HumanResources.happiness += 1;
                        HumanResources.productivity += 1;
                        evaluate[counter] = 2;
                        counter += 1;
                        Instantiate(happy);
                        break;
                    case 20:
                        tipcounter = 21;
                        PlayerManager.score += 10;
                        PlayerManager.tipsCounter = 21;
                        evaluate[counter] = 1;
                        counter += 1;
                        break;
                    case 21:
                        for (int i = 0; i < Production.productsList.Count; i++)
                        {
                            if (Production.productsList[i].Quality<10)
                            {
                                Production.productsList[i].Quality += 1;
                            }
                        }
                        evaluate[counter] = 2;
                        counter += 1;
                        
                        break;
                    case 22:
                        PlayerManager.score += 10;
                        for (int i = 0; i < HumanResources.employeesList.Count; i++)
                        {
                            if (HumanResources.employeesList[i].IsActive)
                            {
                                salary= (int)(HumanResources.employeesList[i].Salary*0.1);
                                HumanResources.employeesList[i].Salary += salary;
                            }
                        }
                        HumanResources.happiness += 2;
                        PlayerManager.score += 10;
                        evaluate[counter] = 1;
                        counter += 1;
                        Instantiate(happy);
                        break;
                    default:
                        break;
                }
                Finances.isOtherInterfaceActive = false;
                Marketing.isOtherInterfaceActive = false;
                HumanResources.isOtherInterfaceActive = false;
                Technology.isOtherInterfaceActive = false;
                Production.isOtherInterfaceActive = false;
                PlayerManager.canShowQuestion = false;
                PlayerManager.questionCounter += 1;
            }
            //B
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                
                Questions[PlayerManager.questionCounter].SetActive(false);
                switch (PlayerManager.questionCounter)
                {
                    case 0:
                        tipcounter = 2;
                        PlayerManager.canShowTip = true;
                        PlayerManager.tipsCounter += 1;
                        Clients.likeProbability = 1;
                        evaluate[counter] = 2;
                        counter += 1;
                        Instantiate(nature);
                        SceneManager.LoadScene("HumanResources");
                        break;
                    case 1:
                        tipcounter = 3;
                        HumanResources.employeesList[0].IsActive = true;
                        HumanResources.employeesList[1].IsActive = true;
                        HumanResources.employeesList[2].IsActive = true;
                        HumanResources.EmployeesCount();
                        evaluate[counter] = 2;
                        counter += 1;
                        SceneManager.LoadScene("Production");
                        break;
                    case 2:
                        tipcounter = 4;
                        evaluate[counter] = 2;
                        counter += 1;
                        Finances.capital -= 10000;
                        Finances.investedCapital += 10000;
                        Production.productsList[0].Amount = 100;
                        InterfaceData.products = Production.productsList[0].Amount;
                        SceneManager.LoadScene("Marketing");
                        //retroalimentacion
                        break;
                    case 3:
                        tipcounter = 5;
                        Finances.capital -= 5000;
                        Finances.investedCapital += 5000;
                        Clients.likeProbability += 1;
                        tvon = true;
                        SceneManager.LoadScene("Technology");
                        //vender panes
                        break;
                    case 4:
                        tipcounter = 6;
                        PlayerManager.score += 10;
                        Finances.capital -= 5000;
                        Finances.investedCapital += 5000;
                        Technology.isUpgradeApplied[1] = true;
                        HumanResources.productivity += 2;
                        HumanResources.happiness += 2;
                        HumanResources.security += 4;
                        registradora = true;
                        PlayerManager.wasOnTutorial = true;
                        SceneManager.LoadScene("Finances");
                        break;
                    case 5:
                        tipcounter = 7;
                        HumanResources.productivity -= 1;
                        HumanResources.security -= 1;
                        Instantiate(sad);
                        break;
                    case 6:
                        tipcounter = 8;
                        PlayerManager.score += 10;
                        //Bonus de vender mas rapido pan por la mañana
                        break;
                    case 7:
                        tipcounter = 9;
                        PlayerManager.score += 10;
                        for (int i = 0; i < 40; i++)
                        {
                            if (HumanResources.employeesList[i].Area == "Producción" && !HumanResources.employeesList[i].IsActive)
                            {
                                HumanResources.employeesList[i].IsActive = true;
                                break;
                            }
                        }
                        HumanResources.EmployeesCount();
                        break;
                    case 8:
                        tipcounter = 10;
                        for (int i = 0; i < 40; i++)
                        {
                            if (HumanResources.employeesList[i].Area == "Producción" && !HumanResources.employeesList[i].IsActive)
                            {
                                HumanResources.employeesList[i].IsActive = true;
                                indexEmployee = i;
                                break;
                            }
                        }
                        HumanResources.EmployeesCount();
                        Instantiate(happy);
                        break;
                    case 9:
                        //notip
                        PlayerManager.score += 10;
                        HumanResources.happiness += 1;
                        HumanResources.productivity += 1;
                        Finances.capital -= 2000;
                        Finances.investedCapital += 2000;
                        Instantiate(murmurs);
                        break;
                    case 10:
                        tipcounter = 11;
                        PlayerManager.score += 10;
                        Clients.likeProbability += 3;
                        Instantiate(Peoplestreet);
                        break;
                    case 11:
                        tipcounter = 12;
                        Finances.capital -= 5000;
                        Finances.investedCapital += 5000;
                        HumanResources.security -= 2;
                        break;
                    case 12:
                        tipcounter = 13;
                        PlayerManager.questionCounter = 15;
                        PlayerManager.score += 10;
                        HumanResources.security += 2;
                        for (int i = 0; i < 40; i++)
                        {
                            if (HumanResources.employeesList[i].Area == "Producción" && HumanResources.employeesList[i].IsActive)
                            {
                                HumanResources.employeesList[i].IsActive = false;
                                Finances.capital -= HumanResources.employeesList[i].Salary;
                                break;
                            }
                        }
                        HumanResources.EmployeesCount();
                        evaluate[counter] = 1;
                        counter += 1;
                        break;
                    case 13:
                        tipcounter = 14;
                        for (int i = 0; i < 40; i++)
                        {
                            if (HumanResources.employeesList[i].Area == "Tecnologia" && !HumanResources.employeesList[i].IsActive)
                            {
                                HumanResources.employeesList[i].IsActive = true;
                                break;
                            }
                        }
                        HumanResources.EmployeesCount();
                        HumanResources.security += 1;
                        break;
                    case 14:
                        tipcounter = 16;
                        PlayerManager.questionCounter = 15;
                        PlayerManager.score += 10;
                        Finances.capital -= 10000;
                        Finances.investedCapital += 10000;
                        HumanResources.security += 2;
                        HumanResources.happiness += 1;
                        servidores = true;
                        break;
                    case 15:
                        tipcounter = 16;
                        PlayerManager.score += 10;
                        Clients.likeProbability += 2;
                        Instantiate(marketing);
                        break;
                    case 16:
                        tipcounter = 18;
                        Finances.capital -= 10000;
                        cajatrigo = true;
                        break;
                    case 17:
                        tipcounter = 19;
                        PlayerManager.score += 10;
                        Instantiate(marketing);
                        break;
                    case 18:
                        tipcounter = 20;
                        PlayerManager.score += 10;
                        Finances.capital -= 5000;
                        Finances.investedCapital += 5000;
                        HumanResources.productivity += 3;
                        HumanResources.happiness += 1;
                        Instantiate(murmurs);
                        break;
                    case 19:
                        //notip
                        Finances.capital -= 3000;
                        Finances.investedCapital += 3000;
                        HumanResources.productivity += 2;
                        HumanResources.happiness += 2;
                        Instantiate(happy);
                        break;
                    case 20:
                        tipcounter = 21;
                        break;
                    case 21:
                        PlayerManager.score += 10;
                        for (int i = 5; i < Production.productsList.Count; i++)
                        {
                            Production.productsList[i].Quality -= 1;
                        }
                        break;
                    case 22:
                        HumanResources.happiness += 1;
                        Instantiate(happy);
                        break;
                    default:
                        break;
                }
                Finances.isOtherInterfaceActive = false;
                Marketing.isOtherInterfaceActive = false;
                HumanResources.isOtherInterfaceActive = false;
                Technology.isOtherInterfaceActive = false;
                Production.isOtherInterfaceActive = false;
                PlayerManager.canShowQuestion = false;
                PlayerManager.questionCounter += 1;
            }
            //C
            if (Input.GetKeyDown(KeyCode.RightArrow) && 
                (PlayerManager.questionCounter!= 0 && PlayerManager.questionCounter != 1 
                && PlayerManager.questionCounter != 5 && PlayerManager.questionCounter != 6
                && PlayerManager.questionCounter != 7 && PlayerManager.questionCounter != 8
                && PlayerManager.questionCounter != 10 && PlayerManager.questionCounter != 11
                && PlayerManager.questionCounter != 13 && PlayerManager.questionCounter != 15
                && PlayerManager.questionCounter != 16 && PlayerManager.questionCounter != 17
                && PlayerManager.questionCounter != 20 && PlayerManager.questionCounter != 21
                && PlayerManager.questionCounter != 22))
            {
                
                Questions[PlayerManager.questionCounter].SetActive(false);
                switch (PlayerManager.questionCounter)
                {
                    case 4:
                        tipcounter = 6;
                        PlayerManager.questionCounter = 7;
                        cpus = true;
                        PlayerManager.wasOnTutorial = true;
                        SceneManager.LoadScene("Finances");
                        break;
                    case 14:
                        PlayerManager.questionCounter = 15;
                        PlayerManager.score += 10;
                        compus = true;
                        break;
                    case 2:
                        tipcounter = 4;
                        Finances.capital -= 10000;
                        Finances.investedCapital += 10000;
                        Production.productsList[0].Amount = 100;
                        InterfaceData.products = Production.productsList[0].Amount;
                        SceneManager.LoadScene("Marketing");
                        //retroalimentacion
                        break;
                    case 3:
                        tipcounter = 5;
                        Finances.capital -= 6500;
                        Finances.investedCapital += 6500;
                        Finances.lostCapital += 1500;
                        SceneManager.LoadScene("Technology");
                        break;
                    case 9:
                        Finances.capital -= 3000;
                        HumanResources.happiness -= 2;
                        HumanResources.productivity -= 2;
                        break;
                    case 12:
                        HumanResources.security -= 2;
                        HumanResources.happiness -= 2;
                        break;
                    case 18:
                        HumanResources.happiness -= 2;
                        Instantiate(disturbs);
                        break;
                    case 19:
                        PlayerManager.score += 10;
                        HumanResources.happiness += 2;
                        Instantiate(happy);
                        break;
                    default:
                        break;
                }
                Finances.isOtherInterfaceActive = false;
                Marketing.isOtherInterfaceActive = false;
                HumanResources.isOtherInterfaceActive = false;
                Technology.isOtherInterfaceActive = false;
                Production.isOtherInterfaceActive = false;
                PlayerManager.canShowQuestion = false;
                PlayerManager.questionCounter += 1;
            }

        }
        if (PlayerManager.questionCounter > 22)
        {
            if (PlayerManager.score<115)
            {
                if (!TextoGameover.wasshown && !TextoGameover.iscapitalgameover)
                {
                    SceneManager.LoadScene("GameOver");
                }              
            }
            else
            {
                if (!TextoGameover.wasshown)
                {
                    SceneManager.LoadScene("Win");
                }
            }
        }
        if (HumanResources.productivity>10)
        {
            HumanResources.productivity = 10;
        }
        if (HumanResources.security>10)
        {
            HumanResources.security = 10;
        }
        if (HumanResources.happiness>10)
        {
            HumanResources.happiness = 10;
        }
        if (Clients.likeProbability>10)
        {
            Clients.likeProbability = 10;
        }
        if (HumanResources.productivity < 0)
        {
            HumanResources.productivity = 0;
        }
        if (HumanResources.security < 0)
        {
            HumanResources.security = 0;
        }
        if (HumanResources.happiness < 0)
        {
            HumanResources.happiness = 0;
        }
        if (Clients.likeProbability < 0)
        {
            Clients.likeProbability = 0;
        }
        
    }
}
