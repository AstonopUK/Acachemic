﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscMovement : MonoBehaviour
{

    [SerializeField] int moveType;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
        switch (moveType)
        {

            case 1:
                gameObject.transform.Rotate(0, +(1 * moveSpeed * Time.deltaTime), 0,Space.Self);
                break;

        }

    }

}
