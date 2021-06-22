using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public GameObject AutoSell;
    public AudioSource hireCook0;
    public AudioSource hireSeller0;
    public AudioSource hireSeller1;
    public AudioSource hireSeller2;
    public AudioSource hireSeller3;
    public AudioSource hireSeller4;
    public int generateTone;


    public void StartAutoCookie()
    {
        hireCook0.Play();
        AutoCookie.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 1.05f;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;
    }

    public void StartAutoSell()
    {
        generateTone = Random.Range(1, 5);
        switch (generateTone)
        {
            case 1:
                hireSeller0.Play();
                break;
            case 2:
                hireSeller1.Play();
                break;
            case 3:
                hireSeller2.Play();
                break;
            case 4:
                hireSeller3.Play();
                break;
            default:
                hireSeller4.Play();
                break;
        }
        AutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 1.05f;
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }
}
