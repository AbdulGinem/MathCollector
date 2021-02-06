using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    
    public static float currentTime = 10f;
    public static float startingTime = 10f;

    public Text countdownText;

    void Start()
    {

        currentTime = 10f;

    }
    public void back()
    {

        currentTime = 10f;

    }

    public void UserStart2()
    {
        currentTime = startingTime;
        countdownText.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            
        }

        if (currentTime <= 5)
        {
            countdownText.color = Color.red;
        }
        else
        {
            countdownText.color = Color.white;
        }




    }
}
