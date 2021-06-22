using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenerate : MonoBehaviour
{
    public bool CreatingCookie = false;
    public static int CookieIncrease = 1;
    public int InternalIncrease;

    // Update is called once per frame
    void Update()
    {
        CookieIncrease = GlobalBaker.bakePerSec;
        InternalIncrease = CookieIncrease;
        if(CreatingCookie == false)
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }    
    }

    IEnumerator CreateTheCookie() {
        GlobalCookies.CookieCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}
