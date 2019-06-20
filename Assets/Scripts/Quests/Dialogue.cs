using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool showDialogue;
    public string[] dialogueTxt;
    public Vector2 screen;
    public int dialogueNum, optionsNum;
    // Use this for initialization
    void Start()
    {
        showDialogue = false;
        Cursor.visible = false;
    }

    //code version of Canvas
    void OnGUI()
    {
        if (showDialogue)
        {
            if (screen.x != Screen.width / 16 || screen.y != Screen.height / 9)
            {
                screen.x = Screen.width / 16;
                screen.y = Screen.height / 9;
            }
            //GUI element of type box
            //new rectangular position and size
            //position x, position y, size, x, size,y
            //content of box
            GUI.Box(new Rect(0, 6 * screen.y, Screen.width, 3 * screen.y), dialogueTxt[dialogueNum]);
            //have a box that touches the left edge and goes to the right edge
            // and starts 2/3rds down the screen and is 1/3rd in size 
            //finiahing at the bottom of the screen 

            //also means index+1 >= dialoguetxt.length
            if (!(dialogueNum >= dialogueTxt.Length - 1 || dialogueNum == optionsNum))
            {
                if (GUI.Button(new Rect(15 * screen.x, 8.5f * screen.y, screen.x, 0.5f * screen.y), "Next"))
                {
                    dialogueNum++;
                }
            }
            else if (dialogueNum == optionsNum)
            {
                if (GUI.Button(new Rect(13 * screen.x, 8.5f * screen.y, screen.x, 0.5f * screen.y), "Accept"))
                {
                    dialogueNum++;
                }
                if (GUI.Button(new Rect(14 * screen.x, 8.5f * screen.y, screen.x, 0.5f * screen.y), "Decline"))
                {
                    dialogueNum = dialogueTxt.Length - 1;
                }
            }
            else
            {
                if (GUI.Button(new Rect(15 * screen.x, 8.5f * screen.y, screen.x, 0.5f * screen.y), "Bye"))
                {
                    dialogueNum = 0;
                    showDialogue = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Movement.canMove = true;
                }
            }
            

        }
    }
}


