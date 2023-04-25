using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketingProductInfo : MonoBehaviour
{
    public Text PriceText;
    public int ButtonID;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PriceText.text =((int)(((Production.productsList[ButtonID - 1].SellingPrice*100) - Production.productsList[ButtonID - 1].BuyingPrice) * 0.25)).ToString();
        //Debug.Log(Production.productsList[ButtonID - 1].SellingPrice*100+" "+ Production.productsList[ButtonID - 1].BuyingPrice+" "+((Production.productsList[ButtonID - 1].SellingPrice - Production.productsList[ButtonID - 1].BuyingPrice) * 0.25));
    }
}
