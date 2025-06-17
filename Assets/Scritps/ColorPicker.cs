using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public Color pickedColor;
    private ColorManager _setColor;
    private void Start()
    {
        pickedColor = GetComponent<MeshRenderer>().material.color;
        _setColor = FindObjectOfType<ColorManager>();


    }
    private void OnMouseDown()
    {
        _setColor.SetColor(pickedColor);
    }

}
