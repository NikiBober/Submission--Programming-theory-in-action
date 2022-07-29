using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : Shape //inheritance
{
    [SerializeField]
    float rotationAngle;

    public override void Move() //polymorphism
    {
        transform.Rotate(Vector3.forward, rotationAngle);
    }

}
