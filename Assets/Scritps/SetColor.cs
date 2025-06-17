using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private ColorManager _colorManager;
    private Renderer _renderer;

    private void Start()
    {
        _colorManager = FindObjectOfType<ColorManager>();
        _renderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        _renderer.material.color = _colorManager._selectedColor;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _renderer.material.SetColor("BaseColor", Color.white);
        }
    }


}
