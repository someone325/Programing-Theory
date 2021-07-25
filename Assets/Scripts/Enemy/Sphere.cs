using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Enemy
{
    private float speed = 2.0f;

    //The sphere moves towards the player
    //POLYMORPHISM
    protected override void Move()
    {
        Vector3 direction = (PlayerControler.Instance.transform.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
