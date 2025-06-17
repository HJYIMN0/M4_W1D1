using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Instantiator2D : MonoBehaviour
{
    [SerializeField] private int _verticalQ = 5;
    [SerializeField] private int _horizontalQ = 5;
    [SerializeField] private float _distance;

    [SerializeField] private GameObject _quad;

    [SerializeField] private Vector3 _startPosition;

    private void Start()
    {
        //Vector3 newPosX = _startPosition;
        //Vector3 newPosY = _startPosition;
        //newPosY.y -= _distance;
        //for (int i = 0; i < _horizontalQ; i++)
        //{
        //    Instantiate(_quad, newPosX, Quaternion.identity);
        //    for (int j = 0; j < _verticalQ; j++)
        //    {
        //        Instantiate(_quad, newPosY, Quaternion.identity);
        //        newPosY.y -= _distance;
        //        if (j == _verticalQ - 1) newPosY.y = _startPosition.y;
        //    }
        //    newPosX.x += _distance;
        //    newPosY.x = newPosX.x;

        Vector3 newPos = _startPosition;
        for (int i = 0; i < _horizontalQ; i++)
        {

            for (int j = 0; j < _verticalQ; j++)
            {
                Instantiate(_quad, newPos * _distance, Quaternion.identity, transform);
                newPos.y -= _distance;
            }
            newPos.y = _startPosition.y; // Reset y position for the next column
            newPos.x += _distance;
        }
    }
}
