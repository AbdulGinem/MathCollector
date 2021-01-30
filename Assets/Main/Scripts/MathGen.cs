using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;


public class MathGen : MonoBehaviour { 

    int a;
    int b;
    public GameObject Question;
    private int score;
    private int Answer;

    public GameObject OptionA;
    public GameObject OptionB;
    public GameObject OptionC;
    public GameObject OptionD;
    
    void Start()
    {
        optionsList.Add(OptionA);
        optionsList.Add(OptionB);
        optionsList.Add(OptionC);
        optionsList.Add(OptionD);
        
        
    }


    List<GameObject> optionsList = new List<GameObject>();
    GameObject choosedOption;

  
    public void UserStart()
    
    {

        score = 0;
        Answer = a + b;
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
        choosedOption = optionsList[Random.Range(0, optionsList.Count -1)];

    }

    void Update()
    {
        Question.GetComponent<Text>().text = a + " + " + b;
    }



}
