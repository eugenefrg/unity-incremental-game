using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameHandler : MonoBehaviour
{
    public int money;
    public int multiplier;
    public Text moneyDisplay;

    public void AddMoney()
    {

        this.money += 1 * this.multiplier;

        moneyDisplay.text = this.money.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        multiplier = 1;
    }
}
