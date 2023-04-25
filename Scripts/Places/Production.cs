using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Production : MonoBehaviour
{
    public static int products;
    public GameObject menuinterface, productsInterface, PausePanel;
    public static bool isMenuActive, isProductsInterfaceActive, isPauseActive,isOtherInterfaceActive;
    public static List<Products> productsList = new List<Products>();
    public Image  brightnessPanel;

    void Start()
    {
        GetTotalProducts();
        UpdateBrightness();
        products = InterfaceData.products;
        if (products == 0)
        {
            productsList = InitializeProducts(productsList);
        }
        productsInterface.SetActive(false);
        menuinterface.SetActive(false);
        isMenuActive = false;
        isProductsInterfaceActive = false;
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!isProductsInterfaceActive && !isMenuActive && !isOtherInterfaceActive) { ShowProductsInterface(); }
            else
            {
                productsInterface.SetActive(false);
                isProductsInterfaceActive = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!isMenuActive && !isProductsInterfaceActive && !isOtherInterfaceActive) { ShowMenu(); }
            else
            {
                menuinterface.SetActive(false);
                isMenuActive = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isMenuActive && !isPauseActive && !isOtherInterfaceActive) { ShowPause(); }
            else {}
        }
        */
    }

    public void ShowProductsInterface()
    {
        productsInterface.SetActive(true);
        menuinterface.SetActive(false);
        PausePanel.SetActive(false);
        isProductsInterfaceActive = true;
    }

    public void ShowMenu()
    {
        menuinterface.SetActive(true);
        PausePanel.SetActive(false);
        productsInterface.SetActive(false);
        isMenuActive = true;
    }
    public void ShowPause()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        productsInterface.SetActive(false);
        menuinterface.SetActive(false);
    }
    public void CloseAll()
    {
        productsInterface.SetActive(false);
        menuinterface.SetActive(false);
        isMenuActive = false;
        isProductsInterfaceActive = false;
        PausePanel.SetActive(false);
    }


        List<Products> InitializeProducts(List<Products> productsList)
    {
        productsList = new List<Products>() {
                new Products(){BuyingPrice=10000,Amount=0,InternetAdsViability=1,SocialMediaViability=2,EventsViability=7,AdvertisingViability=9,Name="panblandito",SellingPrice=150,Quality=5,UpgradePrice=15000,UpgradedLevel=1},
                new Products(){BuyingPrice=20000,Amount=0,InternetAdsViability=6,SocialMediaViability=9,EventsViability=1,AdvertisingViability=4,Name="panrollito",SellingPrice=260,Quality=5,UpgradePrice=20000,UpgradedLevel=1},
                new Products(){BuyingPrice=30000,Amount=0,InternetAdsViability=3,SocialMediaViability=5,EventsViability=1,AdvertisingViability=6,Name="pantreenzado",SellingPrice=370,Quality=5,UpgradePrice=25000,UpgradedLevel=1},
                new Products(){BuyingPrice=45000,Amount=0,InternetAdsViability=1,SocialMediaViability=2,EventsViability=0,AdvertisingViability=6,Name="panblandito",SellingPrice=580,Quality=5,UpgradePrice=15000,UpgradedLevel=1},
                new Products(){BuyingPrice=55000,Amount=0,InternetAdsViability=1,SocialMediaViability=3,EventsViability=0,AdvertisingViability=6,Name="panrollito",SellingPrice=690,Quality=5,UpgradePrice=20000,UpgradedLevel=1},
                new Products(){BuyingPrice=65000,Amount=0,InternetAdsViability=3,SocialMediaViability=5,EventsViability=1,AdvertisingViability=6,Name="pantreenzado",SellingPrice=750,Quality=5,UpgradePrice=25000,UpgradedLevel=1},
                new Products(){BuyingPrice=80000,Amount=0,InternetAdsViability=1,SocialMediaViability=2,EventsViability=0,AdvertisingViability=6,Name="panblandito",SellingPrice=910,Quality=5,UpgradePrice=15000,UpgradedLevel=1},
                new Products(){BuyingPrice=90000,Amount=0,InternetAdsViability=1,SocialMediaViability=3,EventsViability=0,AdvertisingViability=6,Name="panrollito",SellingPrice=1020,Quality=5,UpgradePrice=20000,UpgradedLevel=1},
                new Products(){BuyingPrice=100000,Amount=0,InternetAdsViability=3,SocialMediaViability=5,EventsViability=1,AdvertisingViability=6,Name="pantreenzado",SellingPrice=1130,Quality=5,UpgradePrice=25000,UpgradedLevel=1},
                new Products(){BuyingPrice=150000,Amount=0,InternetAdsViability=3,SocialMediaViability=5,EventsViability=1,AdvertisingViability=6,Name="pantreenzado",SellingPrice=1650,Quality=5,UpgradePrice=25000,UpgradedLevel=1}

        };
        //productsList.Add(new Products() { BuyingPrice = 1, Amount = 10, Viability = 3, Name = "Bell", SellingPrice = 4, Quality = 100 });
        return productsList;
    }

    public static void GetTotalProducts()
    {
        products = 0;
        for (int i = 0; i < productsList.Count; i++) products += productsList[i].Amount;
        PlayerManager.products = products;
    }

    public void UpdateBrightness()
    {
        float brightness;
        brightness = PlayerPrefs.GetFloat("brillo", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightness);
    }
    public static void SellProducts()
    {
        for (int i = 0; i < 10; i++)
        {
            if (productsList[i].Amount > 0)
            {
                Finances.capital += productsList[i].SellingPrice;
                productsList[i].Amount -= 1;
                GetTotalProducts();
                break;
            }
        }
    }
}
