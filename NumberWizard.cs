using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1001;
    int min = 1;
    int guess = 500;
    int x = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome");
        Debug.Log("Please choose a number");
        Debug.Log("Your min number is:" + min + "and your max number is:" + max);
        Debug.Log("Our first guess: " + guess);


    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
            Debug.Log("our guess was right then");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min )/ 2;
           Debug.Log("our guess: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        { 
            Debug.Log("Affferrriiiim Basabiliyon alt oka, bence diplomayi hakettin git MIt ile konus");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("our guess: " + guess);
            Calculator(guess);
            Debug.Log(x);
        }


        void Calculator(int k)
        {
             x = k * k;
        }
    }
}
