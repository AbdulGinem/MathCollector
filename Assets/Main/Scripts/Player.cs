using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.iOS;

public class Player : MonoBehaviour
{
    
    

    void OnMouseDown()
    {
        if (this.gameObject.tag == "Correct") 
        {

            Debug.Log("Correct");

        }
    }


}
