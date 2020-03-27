using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskPlayerMovement : MonoBehaviour
{

    float moveSpeed = 3.0f;
    float rotateSpeed = 2.0f;
    Vector3 movement;
    Vector3 rotation;

    // Start is called before the first frame update
    void Awake()
    {

        

    }

    // Update is called once per frame
    void Update()
    {


        moveDirections();
        transform.position += moveSpeed * Time.smoothDeltaTime * Vector3.ProjectOnPlane(movement, Vector3.forward);
        transform.Rotate(rotation);
        movement = new Vector3(0, 0, 0);

    }

    void moveDirections()
    {

        if (Input.GetKey("w"))
        {

            movement += new Vector3(1, 0, 0);

        }
        if (Input.GetKey("s"))
        {

            movement += new Vector3(-1, 0, 0);

        }
        if (Input.GetKey("a"))
        {

            movement += new Vector3(0, 0, -1);

        }
        if (Input.GetKey("d"))
        {

            movement += new Vector3(0, 0, 1);

        }

    }

}
