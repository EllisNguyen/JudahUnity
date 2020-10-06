/**********************************************************************************************************************
 * Author: Phap Nguyen 
 * Date: 29/09/2020
 * Usage: for Board object
 * Summary: use for the board object, create and align tiles to a grid, also name and parent them properly.
 * *******************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public int width; // Board's width
    public int height; // Board's height
    public GameObject tilePrefab; // Prefab for the tile, any tile

    Tile[,] allTiles; // 2D aray of tiles

    void Start()
    {
        allTiles = new Tile[width, height]; // create new list of tiles with width by height
        SetupTiles(); // Init SetupTiles
    }

    #region SetupTiles

    //Instantiates a grid of tiles, renames the tiles, parents them to the Board>Tile object
    //In the Hierarchy and adds their Tile scripts to the allTiles array
    //Called in Start()

    void SetupTiles()
    {
        for(int row = 0; row < width; row++)
        {
            for(int col = 0; col < height; col++)
            {
                //Instantiate tile prefab at coordinate row and col
                //The tilePrefab instantiated as a GameObject
                //Tile size is 512x512 and 512 pxl per unit, so it's exactly 1 unit squared
                GameObject tile = Instantiate(tilePrefab, new Vector3(row, col, 0), Quaternion.identity) as GameObject;

                //Setup name for each tiles spawned
                tile.name = "Tile (" + row + ", " + col + " )";

                //Store the tilePrefab Tile script at appropriate position in the array
                allTiles[row, col] = tile.GetComponent<Tile>();

                //To keep things tidy, parent the tiles to the object
                //This method might not be good for performance since the script have to scan for all the name to find the name Tiles
                tile.transform.parent = GameObject.Find("Tiles").transform;

                //Call init from Tile and pass it on row and col
                allTiles[row, col].Init(row, col, this);
            }
        }
    }
    #endregion

}
