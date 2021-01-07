using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[ExecuteInEditMode]
public class responsive : MonoBehaviour
{

    private ScreenOrientation _screenOrientation = ScreenOrientation.Unknown;
    public GridLayoutGroup gridLayoutGroup;

    void Start()
    {


    }


    void Update()
    {
        if (Screen.width > Screen.height)
        {
            SetLandscape();
        }
        else
        {
            SetPortarit();
        }
    }

    private void SetPortarit()
    {
        if (_screenOrientation == ScreenOrientation.Portrait)
        {
            return;
        }

        gridLayoutGroup.cellSize = new Vector2(380, 200);
        _screenOrientation = ScreenOrientation.Portrait;
        Debug.Log("Portarit");


    }

    private void SetLandscape()
    {
        if (_screenOrientation == ScreenOrientation.Landscape)
        {
            return;
        }

        gridLayoutGroup.cellSize = new Vector2(380, 85);
        _screenOrientation = ScreenOrientation.Landscape;
        Debug.Log("Landscape");

    }
}
