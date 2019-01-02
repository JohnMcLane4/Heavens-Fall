using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundaries
{
    public float xMin, xMax, zMin, zMax;
}

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

    public float tilt;

    private Vector3 velocity = Vector3.zero;

    private Rigidbody rb;

    public Boundaries boundaries;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    //performs movement on velocity variable
    void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    void FixedUpdate()
    {
        PerformMovement();

        rb.position = new Vector3
            (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundaries.xMin, boundaries.xMax),
            0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundaries.zMin, boundaries.zMax)
            );

        //ship tilt...not working with cube
        rb.rotation = Quaternion.Euler(0f, 0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }
}
