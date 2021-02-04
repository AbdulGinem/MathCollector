using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public UnityEngine.UI.Button button;
    float currentTime = 0f;
    public static float startingTime = 10f;

    public Text countdownText;

    // Start is called before the first frame update
    public void UserStart()
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
            button.onClick.Invoke();
        }

        if (currentTime <= 5)
        {
            countdownText.color = Color.red;
        }




    }
}
