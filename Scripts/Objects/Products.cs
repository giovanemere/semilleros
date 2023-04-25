using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Products : MonoBehaviour
{
    private int buyingPrice, amount, sellingPrice,quality,internetadsViability,socialMediaViability,eventsViability,advertisingViability,upgradePrice,upgradedLevel;
    string name;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public Products()
    {
    }
    public int BuyingPrice
    {
        get { return buyingPrice; }
        set { buyingPrice = value; }
    }
    public int UpgradePrice
    {
        get { return upgradePrice; }
        set { upgradePrice = value; }
    }
    public int Amount
    {
        get { return amount; }
        set { amount = value; }
    }
    public int InternetAdsViability
    {
        get { return internetadsViability; }
        set { internetadsViability = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int SellingPrice
    {
        get { return sellingPrice; }
        set { sellingPrice = value; }
    }
    public int Quality
    {
        get { return quality; }
        set { quality = value; }
    }
    public int SocialMediaViability
    {
        get { return socialMediaViability; }
        set { socialMediaViability = value; }
    }
    public int EventsViability
    {
        get { return eventsViability; }
        set { eventsViability = value; }
    }
    public int AdvertisingViability
    {
        get { return advertisingViability; }
        set { advertisingViability = value; }
    }

    public int UpgradedLevel 
    { 
        get { return upgradedLevel; } 
        set { upgradedLevel = value; }
    }
}
