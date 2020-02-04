using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public int LevelSelect;

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
      
        

    }

    public void LoadScene()
    {

        switch (LevelSelect)
        {

            case 0:
                Application.Quit();
                return;

            case 1:
                SceneManager.LoadScene("MainMenu");
                return;

            case 2:
                SceneManager.LoadScene("Tutorial");
                return;

            case 3:

                return;

            default:
                return;

        }

    }

}
