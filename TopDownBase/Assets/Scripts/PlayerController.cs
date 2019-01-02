using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour {    

    private PlayerMovement movement;    

    void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    void Update ()
    {
        ////Calculate movement velocity as a 3D vector
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMov;
        Vector3 moveVertical = transform.forward * zMov;

        //gives us our movementvector normalized(length=1)
        Vector3 velocitiy = (moveHorizontal + moveVertical).normalized * PlayerStats.instance.movementSpeed;

        //apply movement
        movement.Move(velocitiy);     
        
    }
}
