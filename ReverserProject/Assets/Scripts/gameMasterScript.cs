using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMasterScript : MonoBehaviour
{
    //if  true black's turn false white's turn
    public bool blackTurn = true;

    public void turnTick()
    {
        blackTurn = !blackTurn;
    }

    private void Awake()
    {
        Button[] buttons = FindObjectsOfType<Button>();
        foreach ( Button button in buttons)
        {
            button.GetComponent<Image>().color = Color.green;
        }



        GameObject obj = GameObject.Find("33");
        obj.GetComponent<Image>().color = Color.white;
        obj = GameObject.Find("34");
        obj.GetComponent<Image>().color = Color.black;
        obj = GameObject.Find("43");
        obj.GetComponent<Image>().color = Color.black;
        obj = GameObject.Find("44");
        obj.GetComponent<Image>().color = Color.white;
    }
}
