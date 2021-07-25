using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    //ABSTRACTION and INHERITANCE
    //move is called every frame as long as player is alive
    protected abstract void Move();
    protected void Update()
    {
        if (GameManager.Instance.play) Move();
    }
}
