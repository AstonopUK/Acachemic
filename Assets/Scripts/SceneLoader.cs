using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public int LevelSelect;
    float waitTimer = 0f;
    Color alphaFade;

    // Start is called before the first frame update
    void Start()
    {

        alphaFade.a = 0;

    }

    // Update is called once per frame
    void Update()
    {
      
        if (SceneManager.GetActiveScene().name == "Intro")
        {

            waitTimer += 0.1f * Time.deltaTime;

            if (waitTimer > 0.5f)
            {

                gameObject.GetComponent<MeshRenderer>().material.color = Color.Lerp(gameObject.GetComponent<MeshRenderer>().material.color, alphaFade, 3 * Time.deltaTime);

            }

            LoadScene();

        }

    }

    public void LoadScene()
    {

        switch (LevelSelect)
        {

            case 0:
                Application.Quit();
                return;

            case 1:
                if (waitTimer > 0.8f)
                {

                    SceneManager.LoadScene("Menu");

                }
                return;

            case 2:
                SceneManager.LoadScene("Tutorial");
                return;

            case 3:
                SceneManager.LoadScene("LevelSelect");
                return;

            case 4:
                SceneManager.LoadScene("Periodic");
                return;

            case 5:
                SceneManager.LoadScene("LevelSelect");
                return;

            default:
                return;

        }

    }

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Entered collision with " + collision.gameObject.name);

        if (collision.gameObject.tag == "Hand" || collision.gameObject.tag == "Player")
        {

            LoadScene();

        }

    }

}
