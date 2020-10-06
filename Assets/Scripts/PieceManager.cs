/**********************************************************************************************************************
 * Author: Phap Nguyen 
 * Date: 01/10/2020
 * Usage: Manage pices
 * Summary: 
 * *******************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{

    public GameObject[] gamePiecePref;  //Get the list of all game pieces in game as gameobject
    private GamePiece[,] allGamePiece;  //2D array holding all current game piece with GamePiece script
    private Board board;                //Get Board script

    // Start is called before the first frame update
    void Start()
    {
        board = GameObject.Find("Board").GetComponent<Board>();     //Find Board script from object with the name "Board" in the scene
        allGamePiece = new GamePiece[board.width, board.height];    //Get game piece by it width and height
    }

    //Place game piece at x and y
    //Called by 
    public void PlaceGamePieces(GamePiece gamePiece, int x, int y)
    {
        if(gamePiece = null)        //Check for GamePiece script in the prefab
        {
            Debug.LogWarning("PieceManager: object does not contain GamePiece script!");
            return;                 //Stop the process and return an error if can't find GamePiece script
        }

        //Set the correct x and y position of the game piece
        gamePiece.transform.position = new Vector3(x, y, 0);

        //Set the correct rotation of the game piece
        gamePiece.transform.rotation = Quaternion.identity;

        //Call SetCoord() to populate the board with correct x and y location
        gamePiece.SetCoord(x, y);
    }

    public void FillRandom()
    {
        GameObject spawnPieces;

        for(int row = 0; row < gamePiecePref.Length; row++)
        {
            for (int col = 0; col < gamePiecePref.Length; col++)
            {
                GameObject pieces = Instantiate(spawnPieces, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

                //allGamePiece[row, col] = pieces.GetComponent<GamePiece>();

            }
        }

    }

    //Return random game piece from the prefab array
    //Called by
    GameObject GetRandomGamePiece()
    {
        //Get random number between 0 and the highest number of prefabs in the array
        int randomIdx = Random.Range(0, gamePiecePref.Length);

        //Check if the array contain any prefabs
        if(gamePiecePref[randomIdx] == null)
        {
            Debug.LogWarning("Warning: Element " + randomIdx + " in the prefab list is null");
        }

        //Return selected GamePiece to the function calling it
        return gamePiecePref[randomIdx];
    }
}
