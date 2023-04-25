using UnityEngine;
using UnityEngine.EventSystems;

public class TechUpgradesManager : MonoBehaviour
{

    public void TechUpgrade()
    {
        GameObject ButtonReference = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (!Technology.isUpgradeApplied[ButtonReference.GetComponent<UpgradeButtonInfo>().buttonID - 1] && Finances.capital >= Technology.UpgradePrice[ButtonReference.GetComponent<UpgradeButtonInfo>().buttonID - 1])
        {
            switch (ButtonReference.GetComponent<UpgradeButtonInfo>().buttonID)
            {
                case 1:
                    HumanResources.security += 1;
                    HumanResources.happiness += 1;
                    HumanResources.productivity += 1;
                    BuyUpgrade(ButtonReference);
                    break;
                case 2:
                    HumanResources.security += 1;
                    BuyUpgrade(ButtonReference);
                    break;
                case 3:
                    HumanResources.productivity += 1;
                    BuyUpgrade(ButtonReference);
                    break;
                case 4:
                    HumanResources.security += 1;
                    HumanResources.happiness += 1;
                    HumanResources.productivity += 1;
                    BuyUpgrade(ButtonReference);
                    break;
                case 5:
                    HumanResources.happiness += 1;
                    HumanResources.productivity += 1;
                    for (int i = 0; i < HumanResources.employeesList.Count; i++)
                    {
                        if (HumanResources.employeesList[i].IsActive && HumanResources.employeesList[i].Level<=3)
                        {
                            HumanResources.employeesList[i].Level += 1;
                        }
                    }
                    BuyUpgrade(ButtonReference);
                    break;
                default:
                    break;
            }
        }

    }

    void BuyUpgrade(GameObject ButtonReference)
    {
        Finances.capital -= Technology.UpgradePrice[ButtonReference.GetComponent<UpgradeButtonInfo>().buttonID - 1];
        Finances.investedCapital += Technology.UpgradePrice[ButtonReference.GetComponent<UpgradeButtonInfo>().buttonID - 1];
        Technology.isUpgradeApplied[ButtonReference.GetComponent<UpgradeButtonInfo>().buttonID - 1] = true;
    }

}
