using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Enemy
{
    private float speed = 3.0f;
    private bool forward = true;

    //The cube moves right until it hits a wall and then goes in reverse
    protected override void Move()
    {
        if (forward) transform.Translate(Vector3.right * speed * Time.deltaTime);
        else transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    protected void OnCollisionEnter(Collision collision)
    {
        forward = !forward;
    }
}
