using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private void OnMouseDown()
    {
        Move(); //abstraction
    }

    public abstract void Move(); //polymorphism
}
