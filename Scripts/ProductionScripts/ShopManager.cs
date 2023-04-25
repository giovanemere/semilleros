using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour
{
    public void Buy()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (Finances.capital >= Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].BuyingPrice && InterfaceData.employees > 0)
        {
            PlayerManager.products += 100;
            Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].Amount += 100;
            Production.GetTotalProducts();
            Finances.capital -= Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].BuyingPrice;
            Finances.investedCapital += Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].BuyingPrice;
            
            ButtonReference.GetComponent<BuyButtonInfo>().AmountText.text = Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].Amount.ToString();
        } 
    }
    public void Upgrade()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        //ojo popsible condicional en un futuro para evitar que las mejoras se compren al inicio del juego ocacionando posible perdida del juego
        if (Finances.capital >= Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice)
        {
            Debug.Log(Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradedLevel);
            if (Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradedLevel == 1)
            {
                Finances.capital -= Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice;
                Finances.investedCapital += Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice += 5000;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].SellingPrice += 50;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].BuyingPrice += 1250;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].Quality += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].InternetAdsViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].SocialMediaViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].AdvertisingViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].EventsViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradedLevel = 2;
            }
            else if (Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradedLevel == 2)
            {
                Finances.capital -= Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice;
                Finances.investedCapital += Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice += 5000;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].SellingPrice += 100;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].BuyingPrice += 2500;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].Quality += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].InternetAdsViability += 2;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].SocialMediaViability += 2;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].AdvertisingViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].EventsViability += 2;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradedLevel = 3;
            }
            else if (Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradedLevel == 3)
            {
                Finances.capital -= Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice;
                Finances.investedCapital += Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradePrice += 5000;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].SellingPrice += 75;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].BuyingPrice += 1250;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].Quality += 3;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].InternetAdsViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].SocialMediaViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].AdvertisingViability += 0;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].EventsViability += 1;
                Production.productsList[ButtonReference.GetComponent<BuyButtonInfo>().ButtonID - 1].UpgradedLevel = 4;
            }
        }
    }
}
