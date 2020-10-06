/**********************************************************************************************************************
 * Author: Phap Nguyen 
 * Date: 29/09/2020
 * Usage: for Board object
 * Summary: Init tile and assign x,y and board it's on.
 * *******************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int xIndex; //X location of tile
    public int yIndex; //Y location of tile

    private PieceManager pieceManager; //Get piece manager class
    private Board boardScript; //Get Board class of this tile (useful if you multiple board)

    void Start()
    {
        pieceManager = GameObject.Find("_PieceManager").GetComponent<PieceManager>();
    }


    //Setup xIndex, yIndex and boardScript
    //Pass boardScript in case later if we need more than one
    //Called by Board.SetupTile() at start of level
    public void Init(int x, int y, Board board)
    {
        xIndex = x;             //Store x of tile as x passed by Board.SetupTile()
        yIndex = y;             //Store y of tile as y passed by Board.SetupTile()
        boardScript = board;    //Store boardScript of tile as boardScript passed by Board.SetupTile()
    }
}
