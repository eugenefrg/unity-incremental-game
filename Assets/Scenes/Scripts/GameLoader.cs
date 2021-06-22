using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UDP;

public class GameLoader : MonoBehaviour
{
    public int savedCookies;
    public int savedMoney;
    public int savedBakers;
    public int savedShops;
    public int savedSaveValue;
    public bool isDebug = false;
    IInitListener listener;
    // Start is called before the first frame update
    void Start()
    {
         if(isDebug == false)
        {
            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            savedMoney = PlayerPrefs.GetInt("SavedMoney");
            savedBakers = PlayerPrefs.GetInt("SavedBakers");
            savedShops = PlayerPrefs.GetInt("SavedShops");

            GlobalCookies.CookieCount = savedCookies;
            GlobalMoney.MoneyCount = savedMoney;
            GlobalBaker.numberOfBakers = savedBakers;
            GlobalShop.numberOfShops = savedShops;
        }
      //  StoreService.Initialize(listener);
    }
    public void OnInitialized(UserInfo userInfo)
    {
        Debug.Log("Initialization succeeded");
        // You can call the QueryInventory method here
        // to check whether there are purchases that haven’t be consumed.    
    }

    public void OnInitializeFailed(string message)
    {
        Debug.Log("Initialization failed: " + message);
    }
}
