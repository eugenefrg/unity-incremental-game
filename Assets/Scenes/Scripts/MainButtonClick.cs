using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public bool isPressed;
    public bool isMaking = true;
    public static float makeDelay = 0.2f;
    public GameObject burger;
    public Transform source;
    public AudioSource fryingSound;

    void Update()
    {
        if (isPressed)
        {
            StartCoroutine(SpamClick());
        }
        //Turn the loop on and off depending on the Toggle status
    }

    IEnumerator SpamClick()
    {
        while (isPressed == true && isMaking == true)
        {
            isMaking = false;
            ClickTheButton();
            yield return new WaitForSeconds(makeDelay);
            isMaking = true;
        }
    }
    public void OnPointerDown()
    {
        isPressed = true;
        isMaking = true;
        fryingSound.Play();
    }
    public void OnPointerUp()
    {
        isPressed = false;
        isMaking = false;
        fryingSound.Stop();
    }

    public void ClickTheButton() {
        GlobalCookies.CookieCount += 1;
        DropBurger();
    }

    public void DropBurger() {
        int numx = Random.Range(0,360);
        int numy = Random.Range(0,360);
        int numz = Random.Range(0,360);
        Quaternion spawnrotation = Quaternion.Euler(numx, numy, numz);
            var burgerInstance = Instantiate(burger, source.position, spawnrotation);
            Destroy(burgerInstance, 15f);
    }
}
