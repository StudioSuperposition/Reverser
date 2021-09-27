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
        //if true highlight black's moves if false inverse
        bool checkBlack = GameObject.Find("GameMaster").GetComponent<gameMasterScript>().blackTurn;
        if(checkBlack)
        {

        }
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
            GameObject.Find("GameMaster").GetComponent<gameMasterScript>().turnTick();
        }
        else
        {
            if(gameObject.GetComponent<Image>().color == Color.white)
            {
                gameObject.GetComponent<Image>().color = Color.black;
            }
            else
            {
                gameObject.GetComponent<Image>().color = Color.white;
            }
        }
    }
}
