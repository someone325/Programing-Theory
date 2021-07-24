using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : Enemy
{
    private float speed = 3.0f;
    private bool forward = true;

    //The cube moves forward until it hits a wall and then goes in reverse
    protected override void Move()
    {
        if (forward) transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    protected void OnCollisionEnter(Collision collision)
    {
        forward = !forward;
    }
}
