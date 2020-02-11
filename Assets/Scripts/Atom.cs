using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour
{
    [Header("Atom variables")]
    [SerializeField] int electronCount;
    [SerializeField] int coreCount;
    [SerializeField] string elementType;

    private int[] shellLayers = new int[] { 2, 10, 28, 60, 92, 110, 118 };

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    int[] shellStructure()
    {

        int[] shellStruct = { 0 };
        int fullLayers = 0;

        foreach (int x in shellLayers)
        {

            if (electronCount - x >= 0)
            {

                fullLayers++;

            }

        }

        switch (fullLayers)
        {

            case 0:
                shellStruct = new int[] { 1 };
                break;

            case 1:
                shellStruct = new int[] { 2, 0 };
                break;

            case 2:
                shellStruct = new int[] { 2, 8, 0 };
                break;

            case 3:
                shellStruct = new int[] { 2, 8, 18, 0 };
                break;

            case 4:
                shellStruct = new int[] { 2, 8, 18, 32, 0 };
                break;

            case 5:
                shellStruct = new int[] { 2, 8, 18, 32, 32, 0 };
                break;

            case 6:
                shellStruct = new int[] { 2, 8, 18, 32, 32, 18, 0 };
                break;

            case 7:
                shellStruct = new int[] { 2, 8, 18, 32, 32, 18, 8 };
                break;

        }

        shellStruct[fullLayers] = (electronCount - shellLayers[fullLayers - 1]);

        return shellStruct;

    }

}
