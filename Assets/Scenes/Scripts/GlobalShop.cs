using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{

    public GameObject realButton;
    public GameObject realText;
    public float currentCash;
    public static float shopValue = 50f;
    public static int numberOfShops = 0;
    public static int shopPerSec;
    public static bool turnOffButton = false;
    public GameObject shopStats;


    void Update()
    {
        currentCash = GlobalMoney.MoneyCount;
        shopStats.GetComponent<Text>().text = numberOfShops + " x";
        realText.GetComponent<Text>().text = "$" + shopValue;
        if (currentCash >= shopValue)
        {
            realButton.GetComponent<Button>().interactable = true;
        }
        if (currentCash <= shopValue || turnOffButton == true)
        {
            realButton.GetComponent<Button>().interactable = false;
            turnOffButton = false;
        }
    }
}
