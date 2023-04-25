using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketingButtons : MonoBehaviour
{
    public GameObject EventsPanel, InternetAdsPanel, StrongSalesPanel, SocialMediaPanel;
    public bool isEvents, isAds, isSales, IsSocialM;
    void Start()
    {
        EventsPanel.SetActive(false);
        InternetAdsPanel.SetActive(false);
        StrongSalesPanel.SetActive(false);
        SocialMediaPanel.SetActive(false);
        isEvents = true;
        isAds = false;
        isSales = false;
        IsSocialM = false;
    }

    void Update()
    {
    }
    public void ActivateEventsPanel()
    {
        EventsPanel.SetActive(true);
        InternetAdsPanel.SetActive(false);
        StrongSalesPanel.SetActive(false);
        SocialMediaPanel.SetActive(false);
        isEvents = true;
        isAds = false;
        isSales = false;
        IsSocialM = false;
    }
    public void ActivateInternetAdsPanel()
    {
        EventsPanel.SetActive(false);
        InternetAdsPanel.SetActive(true);
        StrongSalesPanel.SetActive(false);
        SocialMediaPanel.SetActive(false);
        isEvents = false;
        isAds = true;
        isSales = false;
        IsSocialM = false;
    }
    public void ActivateStrongSalesPanel()
    {
        EventsPanel.SetActive(false);
        InternetAdsPanel.SetActive(false);
        StrongSalesPanel.SetActive(true);
        SocialMediaPanel.SetActive(false);
        isEvents = false;
        isAds = false;
        isSales = true;
        IsSocialM = false;
    }
    public void ActivateSocialMediaPanel()
    {
        EventsPanel.SetActive(false);
        InternetAdsPanel.SetActive(false);
        StrongSalesPanel.SetActive(false);
        SocialMediaPanel.SetActive(true);
        isEvents = false;
        isAds = false;
        isSales = false;
        IsSocialM = true;
    }
    public void CloseAll()
    {
        EventsPanel.SetActive(false);
        InternetAdsPanel.SetActive(false);
        StrongSalesPanel.SetActive(false);
        SocialMediaPanel.SetActive(false);
    }
    public void BackofMenu()
    {
        if (isEvents)
        {
            ActivateEventsPanel();
        }
        else if (isAds)
        {
            ActivateInternetAdsPanel();
        }
        else if (isSales)
        {
            ActivateStrongSalesPanel();
        }
        else if (IsSocialM)
        {
            ActivateSocialMediaPanel();
        }
    }
}
