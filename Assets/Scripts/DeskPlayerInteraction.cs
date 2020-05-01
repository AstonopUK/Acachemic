using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskPlayerInteraction : MonoBehaviour
{

    public float interactRange = 0.001f;
    public bool isInteract;

    // Start is called before the first frame update
    void Awake()
    {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {        

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, interactRange))
            {

                isInteract = (hit.collider.tag == "Clickable");
                Debug.Log("Interacted with " + hit.collider.name);

                if (isInteract)
                {

                    Interaction intEff = hit.collider.gameObject.GetComponent<Interaction>();
                    intEff.runOperation();

                }

            }

        }

        

    }

}
