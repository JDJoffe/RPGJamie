using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hardcoding101 : MonoBehaviour
{
    public float screenW, screenH;
    private void OnGUI()
    {
        if (screenW != Screen.width/16)
        {
            
            screenW = Screen.width / 16;
            screenH = Screen.height / 9;
        }
        //if (GUI.Button(new Rect(0, 0, screenH*3, screenW*1.5f), "Button"))
        //{

        //}
        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GUI.Box(new Rect(screenW * x, screenH * y, screenW, screenH),"");
            }
        }
    }
}
