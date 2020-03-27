using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus
{

    public class MenuControls : MonoBehaviour
    {

        public int ControlSys;
        public GameObject DesktopPlayer;
        public GameObject VRPlayer;
        public AudioSource Click;
        public bool spawnCheck = false;

        // Start is called before the first frame update
        void Start()
        {            
         
            DontDestroyOnLoad(gameObject);

        }

        // Update is called once per frame
        void Update()
        {

            if (spawnCheck == false)
            {

                if (ControlSys == 1)
                {

                    Instantiate(DesktopPlayer, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnCheck = true;

                }
                else if (ControlSys == 2)
                {

                    Instantiate(VRPlayer, new Vector3(0, 0, 0), Quaternion.identity);
                    spawnCheck = true;

                }

            }

        }

        public void SetDesktop()
        {

            Click.Play();
            ControlSys = 1;
            SceneManager.LoadScene("Intro");

        }

        public void SetVR()
        {

            Click.Play();
            ControlSys = 2;
            SceneManager.LoadScene("Intro");

        }

    }

}