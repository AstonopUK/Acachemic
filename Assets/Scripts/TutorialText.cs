using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour
{

    const int arraySize = 10;

    [SerializeField] Text textField;
    string[] textReel = new string[arraySize];
    string printString;
    int intIncrementor = 0;
    int lastChange = -1;

    // Start is called before the first frame update
    void Start()
    {

        textReel[0] = "Hello! Welcome to the tutorial.";
        textReel[1] = "This tutorial will lead you through the basics of navigating the Acachemic world.";

    }

    // Update is called once per frame
    void Update()
    {

        if (intIncrementor != lastChange)
        {

            lastChange = intIncrementor;
            textField.text = "";

            foreach (char x in textReel[intIncrementor])
            {

                printString += x;
                textField.text = printString;

            }

        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        intIncrementor++;

    }

}
