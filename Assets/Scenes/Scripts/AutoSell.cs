using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;

    // Update is called once per frame
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingCookie == false)
        {
            SellingCookie= true;
            StartCoroutine(SellTheCookie());
        }
    }

    IEnumerator SellTheCookie()
    {
        if (GlobalCookies.CookieCount == 0)
        {

        } else
        {
            GlobalMoney.MoneyCount += InternalIncrease;
            GlobalCookies.CookieCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
    }
}
