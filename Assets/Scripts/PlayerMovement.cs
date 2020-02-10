using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerMovement : MonoBehaviour
{

    public SteamVR_Action_Vector2 moveInput;
    public float moveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 faceForward = Player.instance.hmdTransform.TransformDirection(new Vector3(moveInput.axis.x, 0, moveInput.axis.y));
        transform.position += moveSpeed * Time.smoothDeltaTime * Vector3.ProjectOnPlane(faceForward, Vector3.up);

    }

}
