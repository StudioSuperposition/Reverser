using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boardController : MonoBehaviour
{
    public void updateBoard()
    {

    }
    public void moveHighlight()
    {

    }
    public void flipOwner()
    {
        Debug.Log("This object is " + this.gameObject);
        if(gameObject.GetComponent<Image>().color == Color.green)
        {
            if(GameObject.Find("GameMaster").GetComponent<gameMasterScript>().blackTurn)
            {
                this.gameObject.GetComponent<Image>().color = Color.black;
            }
            else
            {
                gameObject.GetComponent<Image>().color = Color.white;
            }
        }
    }
}
