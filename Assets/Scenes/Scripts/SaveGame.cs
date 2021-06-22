using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public float saveGameCash;
    public GameObject saveButton;
    public GameObject saveText;

    public void SaveTheGame() {
        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetFloat("SavedMoney", GlobalMoney.MoneyCount);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.numberOfBakers);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);
    }
}
