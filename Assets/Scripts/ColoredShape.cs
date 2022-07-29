using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredShape : Shape
{
    [SerializeField]
    Color colorToSet;

    // Start is called before the first frame update
    void Start()
    {
        SetColor();
    }

    void SetColor()
    {
        GetComponent<SpriteRenderer>().color = colorToSet;
    }
}
