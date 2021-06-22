using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave : MonoBehaviour
{
    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetFloat("SavedMoney", GlobalMoney.MoneyCount);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.numberOfBakers);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);
    }
}


