using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathGen : MonoBehaviour { 

   int a;
   int b;
   public GameObject Question;
 

    void Start()
    
    {
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
    }

    void Update()
    {
        Question.GetComponent<Text>().text = a + " + " + b;
    }



}
