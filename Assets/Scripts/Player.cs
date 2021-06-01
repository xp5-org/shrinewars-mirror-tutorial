using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            //3d space mouse driver is causing some problem with unity
            //Horizontal
            float moveHorizontal = 0;
            if (Input.GetKey(KeyCode.A))
                moveHorizontal = -1;
            if (Input.GetKey(KeyCode.D))
                moveHorizontal = 1;

            //Vertical
            float moveVertical = 0;
            if (Input.GetKey(KeyCode.S))
                moveVertical = -1;
            if (Input.GetKey(KeyCode.W))
                moveVertical = 1;


            Vector3 movement = new Vector3(moveHorizontal * 0.01f, moveVertical * 0.01f, 0);
            transform.position = transform.position + movement;

        }
    }
    
    void Update()
    {
        HandleMovement();
        print("Input: " + Input.GetAxis("Horizontal"));
        print("Input: " + Input.GetAxis("Vertical"));

    }
}
