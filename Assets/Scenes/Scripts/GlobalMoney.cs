using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public static float MoneyCount;
    public GameObject MoneyDisplay;
    public float InternalMoney;
    // Update is called once per frame
    void Update()
    {
        InternalMoney = MoneyCount;
        MoneyDisplay.GetComponent<Text>().text = "$ " + InternalMoney;
    }
}
