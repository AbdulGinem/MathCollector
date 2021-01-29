using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MathGen : MonoBehaviour { 

    int a;
    int b;
    public GameObject Question;
    private int score;
    private int Answer;

    public GameObject OptionB;
    public GameObject OptionC;
    public GameObject OptionD;
    

    public List<GameObject> optionsList = new List<GameObject>();
    GameObject choosedOption;



    void ChooseRandomOption()
    {
        choosedOption = optionsList[Random.Range(0, optionsList.Count)];
    }



    public void UserStart()
    
    {
        score = 0;
        Answer = a + b;
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
        NextQuestion();

    }

    public void NextQuestion()
    {

        Debug.Log(choosedOption);
        
    }

    void Update()
    {
        Question.GetComponent<Text>().text = a + " + " + b;
    }



}
