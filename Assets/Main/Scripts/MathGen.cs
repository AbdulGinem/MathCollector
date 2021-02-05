using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;
using UDebug = UnityEngine.Debug;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;


public class MathGen : MonoBehaviour
{

    public GameObject Question;
    public GameObject ScoreObj;
    public UnityEngine.UI.Button button;
    int a;
    int b;
    int Score;
    int Answer;
    int Fake1;
    int Fake2;
    int Fake3;
    int Fake4;
    bool Option1;
    bool Option2;
    bool Option3;
    bool Option4;
    bool Chosen;
    public GameObject OptionA;
    public GameObject OptionB;
    public GameObject OptionC;
    public GameObject OptionD;

    List<GameObject> optionsList = new List<GameObject>();
    GameObject choosedOption;
    void Awake()
    {
        optionsList.Add(OptionA);
        optionsList.Add(OptionB);
        optionsList.Add(OptionC);
        optionsList.Add(OptionD);
        UDebug.Log("On Awake");
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
        choosedOption = optionsList[Random.Range(0, optionsList.Count)];

        
    }



    void Start()
    {
        
        UDebug.Log(Option1);
        UDebug.Log(Option2);
        UDebug.Log(Option3);
        UDebug.Log(Option4);


    }

  

public void UserStart()
    {
        Score = 0;
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
        choosedOption = optionsList[Random.Range(0, optionsList.Count)];
      

        

    }



    public void NextA() // this is called through a Button
    {
        if (Option1 == true)
        {
            UDebug.Log("Correct");
            Score++;
            CountDown.currentTime = 10f;
            a = Random.Range(0, 10);
            b = Random.Range(0, 10);
            choosedOption = optionsList[Random.Range(0, optionsList.Count)];

        }

        if (Option1 == false)
        {
          
            UDebug.Log("Not Correct");
            button.onClick.Invoke();
           
        }

    }

    public void NextB() // this is called through a Button
    {
        if (Option2 == true)
        {
            UDebug.Log("Correct");
            Score++;
            CountDown.currentTime = 10f;
            a = Random.Range(0, 10);
            b = Random.Range(0, 10);
            choosedOption = optionsList[Random.Range(0, optionsList.Count)];


        }

        if (Option2 == false)
        {

            UDebug.Log("Not Correct");
            button.onClick.Invoke();
            
        }

    }

    public void NextC() // this is called through a Button
    {
        if (Option3 == true)
        {
            UDebug.Log("Correct");
            Score++;
            CountDown.currentTime = 10f;
            a = Random.Range(0, 10);
            b = Random.Range(0, 10);
            choosedOption = optionsList[Random.Range(0, optionsList.Count)];

        }

        if (Option3 == false)
        {

            UDebug.Log("Not Correct");
            button.onClick.Invoke();
            
        }

    }

    public void NextD() // this is called through a Button
    {
        if (Option4 == true)
        {
            UDebug.Log("Correct");
            Score++;
            CountDown.currentTime = 10f;
            a = Random.Range(0, 10);
            b = Random.Range(0, 10);
            choosedOption = optionsList[Random.Range(0, optionsList.Count)];
        }

        if (Option4 == false)
        {

            UDebug.Log("Not Correct");
            button.onClick.Invoke();
            
        }

    }
    void Update()
    {
        Question.GetComponent<Text>().text = a + " + " + b;
        ScoreObj.GetComponent<TMP_Text>().text ="Score : " + Score;
        Answer = a + b;
        Fake1 = a + b + 5;
        Fake2 = a + b + 1;
        Fake3 = a + b + 3;
        Fake4 = a + b + 10;

        if (choosedOption == OptionA)
        {
            OptionA.GetComponent<TMP_Text>().text = Answer.ToString();
            Option1 = true;
        }
        else
        {
            OptionA.GetComponent<TMP_Text>().text = Fake1.ToString();
            Option1 = false;
        }

        if (choosedOption == OptionB)
        {
            OptionB.GetComponent<TMP_Text>().text = Answer.ToString();
            Option2 = true;
        }
        else
        {
            OptionB.GetComponent<TMP_Text>().text = Fake2.ToString();
            Option2 = false;
        }

        if (choosedOption == OptionC)
        {
            OptionC.GetComponent<TMP_Text>().text = Answer.ToString();
            Option3 = true;
        }
        else
        {
            OptionC.GetComponent<TMP_Text>().text = Fake3.ToString();
            Option3 = false;
        }

        if (choosedOption == OptionD)
        {
            OptionD.GetComponent<TMP_Text>().text = Answer.ToString();
            Option4 = true;
        }
        else
        {
            OptionD.GetComponent<TMP_Text>().text = Fake4.ToString();
            Option4 = false;
        }

        if (CountDown.currentTime <= 0)
        {

            UDebug.Log("Fail");
            button.onClick.Invoke();


        }

    }




}