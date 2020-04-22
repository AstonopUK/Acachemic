using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PeriodicChoice : MonoBehaviour
{

    [SerializeField] Text Body;
    string textChange;

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
       
        

    }

    public void InfoChange(string element)
    {

        string path = ("Assets/Txts/" + element + ".txt");

        StreamReader reader = new StreamReader(path);
        textChange = reader.ReadToEnd();
        reader.Close();

        Body.text = textChange;

    }

}
