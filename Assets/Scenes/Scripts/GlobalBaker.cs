using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject realButton;
    public GameObject realText;
    public float currentCash;
    public static float bakerValue = 50f;
    public static int numberOfBakers = 0;
    public static int bakePerSec;
    public static bool turnOffButton = false;
    public GameObject bakerStats;


    void Update()
    {
        currentCash = GlobalMoney.MoneyCount;
        bakerStats.GetComponent<Text>().text = numberOfBakers + " x";
        realText.GetComponent<Text>().text = "$" + bakerValue;
        if (currentCash >= bakerValue)
        {
            realButton.GetComponent<Button>().interactable = true;
        }
        if(currentCash <= bakerValue | turnOffButton == true)
        {
            realButton.GetComponent<Button>().interactable = false;
            turnOffButton = false;
        }
    }
}
