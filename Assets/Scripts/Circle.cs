using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : ColoredShape //inheritance
{
    public override void Move() //polymorphism
    {
        base.Move();
        transform.Translate(Vector3.right);
    }
}
