using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{

    [SerializeField] string runMode;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void runOperation()
    {

        switch (runMode)
        {

            case "LevelSelect":
                SceneLoader scnLdr = gameObject.GetComponent<SceneLoader>();
                scnLdr.LoadScene();
                break;

            case "Element":
                PeriodicChoice prdChc = gameObject.GetComponent<PeriodicChoice>();
                prdChc.InfoChange(gameObject.name);
                break;

            default:
                break;

        }

    }

}
