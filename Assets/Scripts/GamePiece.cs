/**********************************************************************************************************************
 * Author: Phap Nguyen 
 * Date: 01/10/2020
 * Usage: control the piece in game
 * Summary: 
 * *******************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{

    public int xIndex; //Get current x coordinate
    public int yIndex; //Get current y coordinate


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetCoord(int x, int y)
    {
        xIndex = x;     //Set xIndex to the x value called
        yIndex = y;     //Set yIndex to the y value called
    }

}
