using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 3.0f;
    public static PlayerControler Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.play)
        {
            //Move with input
            float horizontalinput = Input.GetAxis("Horizontal");
            float verticalinput = Input.GetAxis("Vertical");
            Vector3 move_direction = new Vector3(horizontalinput, 0, verticalinput);
            transform.Translate(move_direction * speed * Time.deltaTime, Space.World);
            //Stop Out of bounds
            if (transform.position.z < -4.6) transform.position = new Vector3(transform.position.x, transform.position.y, -4.6f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.End_Game(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.Instance.End_Game(true);
        }
    }
}
