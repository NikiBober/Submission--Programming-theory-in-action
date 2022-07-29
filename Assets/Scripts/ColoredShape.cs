using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredShape : Shape //inheritance
{
    [SerializeField]
    Color m_colorToSet;
    public Color ColorToSet
    {
        get { return m_colorToSet; } //encapsulation with backing field
    }

    void Start()
    {
        SetColor(); //abstraction
    }

    void SetColor()
    {
        GetComponent<SpriteRenderer>().color = ColorToSet;
    }

    public override void Move() //polymorphism
    {
        transform.Translate(Vector3.up);
    }
}
