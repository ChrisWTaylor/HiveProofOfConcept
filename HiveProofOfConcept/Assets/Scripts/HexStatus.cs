using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexStatus : MonoBehaviour
{
   

    //Int Array which holds the gamebaord cordantes for this hex, has getter and setter function
    public int[] gameBoardCoords = new int[2];
    //Refernce to text mesh object for displaying the game board coordinates
    public TextMesh coordsText;
    void Start()
    {
        coordsText = transform.Find("GameBoardPositionText").GetComponent<TextMesh>();
        coordsText.text = "[" + gameBoardCoords[0].ToString() + "," + gameBoardCoords[1].ToString() + "]";//Set Debug UI to displaycords
    }

    // Update is called once per frame
    void Update()
    {
       //if "A" Key is pressed toggle Debug UI
        if (Input.GetKeyDown(KeyCode.L)) ToggleCoordinateUI();
    }

    /// <summary>
    /// Set the Game Board Coordinates for this Hex
    /// </summary
    /// <param name="rowCord">Row Coordinate in the Game Board for this hex</param>
    /// <param name="colCord">Row Coordinate in the Game Board for this hex</param>
    public void SetGameBoardCords(int rowCord, int colCord)
    {
        gameBoardCoords[0] = rowCord;
        gameBoardCoords[1] = colCord;
    }

    /// <summary>
    /// Get the GameBoard coordinates for this hex
    /// </summary>
    /// <returns>Int Array [Row,Col]</returns>
    public int[] GetGameBoardCords()
    {
        return gameBoardCoords;
    }


    /// <summary>
    /// Fuction to toggle debug UI which shows the coordinates for each hex on gameboards
    /// </summary>
    public void ToggleCoordinateUI()
    {
            if (coordsText != null)
            {
                if (coordsText.gameObject.activeSelf)
                {
                    coordsText.gameObject.SetActive(false); //Set coordinate Text GameObject to hide
                }
                else
                {
                    coordsText.gameObject.SetActive(true);//Set coordinate Text GameObject to show
                }
            }
    }
}
