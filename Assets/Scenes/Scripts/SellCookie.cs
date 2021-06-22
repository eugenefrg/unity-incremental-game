using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SellCookie : MonoBehaviour
{
    public GameObject StatusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public AudioSource cash3;
    public AudioSource cash4;
    public int generateTone;


    public void ClickTheButton()
    {
        generateTone = Random.Range(1, 5);
        if (GlobalCookies.CookieCount >= 1)
        {
            GlobalCookies.CookieCount -= 1;
            GlobalMoney.MoneyCount += 1;
            switch(generateTone)
            {
                case 1:
                    cashOne.Play();
                    break;
                case 2:
                    cashTwo.Play();
                    break;
                case 3:
                    cash3.Play();
                    break;
                case 4:
                    cash4.Play();
                    break;
                default:
                    cashOne.Play();
                    break;
            }

        }
        else
        {
            StatusBox.GetComponent<Text>().text = "Not Enough Burgers to sell";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }
    public void SellAll()
    {
        generateTone = Random.Range(1, 3);
        if (GlobalCookies.CookieCount >= 1)
        {
            GlobalMoney.MoneyCount += GlobalCookies.CookieCount;
            GlobalCookies.CookieCount = 0;
            if (generateTone == 1)
            {
                cashOne.Play();
            }
            if (generateTone == 2)
            {
                cashTwo.Play();
            }

        }
        else
        {
            StatusBox.GetComponent<Text>().text = "Nothing to sell";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }
}
