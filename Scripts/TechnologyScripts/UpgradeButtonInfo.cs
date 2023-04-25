using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButtonInfo : MonoBehaviour
{
    public Text PriceText;
    public int buttonID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PriceText.text = "Precio: $" + Technology.UpgradePrice[buttonID - 1].ToString();
    }
}
