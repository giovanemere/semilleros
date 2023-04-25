using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MarketingEvents : MonoBehaviour
{
    private int totalViability,QuantitytoSell,randomvariable,buyPrice,sellingPrice;
    public void Events()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        buyPrice = (int)(((Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice*100) - Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].BuyingPrice) * 0.25);
        if (Finances.capital >= buyPrice)
        {
            Finances.capital -= buyPrice;
            Finances.investedCapital += buyPrice;
            totalViability = Production.productsList[ButtonReference.GetComponent <MarketingProductInfo>().ButtonID - 1].EventsViability;
            if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality<5)
            {
                totalViability -= 1;
            }
            else if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality > 7)
            {
                totalViability += 1;
            }
            if (Clients.likeProbability<5)
            {
                totalViability -= 1;
            }
            else if (Clients.likeProbability > 7)
            {
                totalViability += 1;
            }
            if (HumanResources.productivity>5)
            {
                totalViability += 1;
            }
            if (totalViability>5)
            {
                randomvariable = Random.Range(totalViability, 10);
            }
            else
            {
                randomvariable = Random.Range(0, totalViability);
            }
            QuantitytoSell = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount * randomvariable / 10;
            sellingPrice= Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell;
            if (sellingPrice<buyPrice)
            {
                Finances.lostCapital += (buyPrice - sellingPrice);
            }
            if (sellingPrice>buyPrice)
            {
                Finances.profit += (sellingPrice - buyPrice);
            }
                Finances.capital += (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell);
                Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount -= QuantitytoSell;
            Debug.Log(buyPrice);
        }
    }
    public void SocialMedia()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        buyPrice = (int)(((Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * 100) - Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].BuyingPrice) * 0.25);
        if (Finances.capital >= buyPrice)
        {
            Finances.capital -= buyPrice;
            Finances.investedCapital += buyPrice;
            totalViability = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SocialMediaViability;
            if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality < 5)
            {
                totalViability -= 1;
            }
            else if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality > 7)
            {
                totalViability += 1;
            }
            if (Clients.likeProbability < 5)
            {
                totalViability -= 1;
            }
            else if (Clients.likeProbability > 7)
            {
                totalViability += 1;
            }
            if (HumanResources.productivity > 5)
            {
                totalViability += 1;
            }
            if (totalViability > 5)
            {
                randomvariable = Random.Range(totalViability, 10);
            }
            else
            {
                randomvariable = Random.Range(0, totalViability);
            }
            QuantitytoSell = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount * randomvariable / 10;
            sellingPrice = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell;
            if (sellingPrice < buyPrice)
            {
                Finances.lostCapital += (buyPrice - sellingPrice);
            }
            if (sellingPrice > buyPrice)
            {
                Finances.profit += (sellingPrice - buyPrice);
            }
            Finances.capital += (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell);
            Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount -= QuantitytoSell;
            //Debug.Log("quantiti" + QuantitytoSell + "prods" + Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount + "random" + randomvariable + "viabi" + totalViability + "operacion" + (randomvariable / 10));

        }
    }
    public void InternetAds()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        buyPrice = (int)(((Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * 100) - Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].BuyingPrice) * 0.25);
        if (Finances.capital >= buyPrice)
        {
            Finances.capital -= buyPrice;
            Finances.investedCapital += buyPrice;
            totalViability = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].InternetAdsViability;
            if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality < 5)
            {
                totalViability -= 1;
            }
            else if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality > 7)
            {
                totalViability += 1;
            }
            if (Clients.likeProbability < 5)
            {
                totalViability -= 1;
            }
            else if (Clients.likeProbability > 7)
            {
                totalViability += 1;
            }
            if (HumanResources.productivity > 5)
            {
                totalViability += 1;
            }
            if (totalViability > 5)
            {
                randomvariable = Random.Range(totalViability, 10);
            }
            else
            {
                randomvariable = Random.Range(0, totalViability);
            }
            QuantitytoSell = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount * randomvariable / 10;
            sellingPrice = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell;
            if (sellingPrice < buyPrice)
            {
                Finances.lostCapital += (buyPrice - sellingPrice);
            }
            if (sellingPrice > buyPrice)
            {
                Finances.profit += (sellingPrice - buyPrice);
            }
            Finances.capital += (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell);
            Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount -= QuantitytoSell;
            //Debug.Log("quantiti" + QuantitytoSell + "prods" + Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount + "random" + randomvariable + "viabi" + totalViability + "operacion" + (randomvariable / 10));

        }
    }
    public void StrongSales()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        buyPrice = (int)(((Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * 100) - Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].BuyingPrice) * 0.25);
        if (Finances.capital >= buyPrice)
        {
            Finances.capital -= buyPrice;
            Finances.investedCapital += buyPrice;
            totalViability = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].AdvertisingViability;
            if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality < 5)
            {
                totalViability -= 1;
            }
            else if (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Quality > 7)
            {
                totalViability += 1;
            }
            if (Clients.likeProbability < 5)
            {
                totalViability -= 1;
            }
            else if (Clients.likeProbability > 7)
            {
                totalViability += 1;
            }
            if (HumanResources.productivity > 5)
            {
                totalViability += 1;
            }
            if (totalViability > 5)
            {
                randomvariable = Random.Range(totalViability, 10);
            }
            else
            {
                randomvariable = Random.Range(0, totalViability);
            }
            QuantitytoSell = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount * randomvariable / 10;
            sellingPrice = Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell;
            if (sellingPrice < buyPrice)
            {
                Finances.lostCapital += (buyPrice - sellingPrice);
            }
            if (sellingPrice > buyPrice)
            {
                Finances.profit += (sellingPrice - buyPrice);
            }
            Finances.capital += (Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].SellingPrice * QuantitytoSell);
            Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount -= QuantitytoSell;
            Debug.Log("quantiti" + QuantitytoSell + "prods" + Production.productsList[ButtonReference.GetComponent<MarketingProductInfo>().ButtonID - 1].Amount + "random" + randomvariable + "viabi" + totalViability + "operacion" + (randomvariable / 10));

        }
    }
}
