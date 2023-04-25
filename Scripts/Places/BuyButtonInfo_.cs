using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButtonInfo_ : MonoBehaviour
{
    public int ButtonID;
    public Text PriceText, AmountText, Qualitytext, UpgradePrice, LevelText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PriceText.text = "Precio: $" + Production.productsList[ButtonID - 1].BuyingPrice.ToString();
        AmountText.text = "cantidad: " + Production.productsList[ButtonID - 1].Amount.ToString();
        Qualitytext.text = "Calidad: " + Production.productsList[ButtonID - 1].Quality.ToString();
        UpgradePrice.text = "Precio: $" + Production.productsList[ButtonID - 1].UpgradePrice.ToString();
        LevelText.text = Production.productsList[ButtonID - 1].UpgradedLevel.ToString();
    }
}
