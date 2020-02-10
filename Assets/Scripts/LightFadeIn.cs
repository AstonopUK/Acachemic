using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFadeIn : MonoBehaviour
{

    Light mainLight;

    // Start is called before the first frame update
    void Start()
    {

        mainLight = gameObject.GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (mainLight.intensity < 1)
        {

            mainLight.intensity += 0.1f;

        }

    }

}
