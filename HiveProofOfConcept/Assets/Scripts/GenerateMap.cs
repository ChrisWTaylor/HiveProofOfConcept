using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    /** This script is designed to generate the map playing field 
     and then store the locations in an array for reference later.**/

    public GameObject hexPrefab; //hex Prefab for board

    //Sets number of rows in map size
    public int map_rows; 
    //Sets number of columns in map size
    public int map_columns;

    //array to hold tile by index
    public GameObject[,] maptiles;

    //offset to space the model based on hex size
    private float xOffset = 0.88f;
    private float zOffset = .765f;
    void Start()
    {
        maptiles = new GameObject[map_rows,map_columns];

        for (int tempRow = 0; tempRow < map_rows; tempRow++)
        {
            for (int tempCol = 0; tempCol < map_columns; tempCol++)
            {
                //Create a hex prefabe for each index of the array to c
                //to creat the map and store for later use
                //xoffset to space correctly for the model
               //check is col number is odd, if so need to shift the row over by hlaf of xOffset
               if (tempCol % 2 != 0) {
                    maptiles[tempRow, tempCol] = Instantiate(hexPrefab, new Vector3((tempRow * xOffset) + (xOffset/2) , 0, tempCol * zOffset), Quaternion.identity);
                }
                else{
                    maptiles[tempRow, tempCol] = Instantiate(hexPrefab, new Vector3(tempRow * xOffset, 0, tempCol *zOffset), Quaternion.identity);
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
