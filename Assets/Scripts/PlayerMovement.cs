using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerMovement : MonoBehaviour
{

    public SteamVR_Action_Vector2 moveInput;
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += moveSpeed * Time.smoothDeltaTime * new Vector3(moveInput.axis.x, 0, moveInput.axis.y);

    }

}
