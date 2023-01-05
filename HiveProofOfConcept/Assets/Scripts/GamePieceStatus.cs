using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePieceStatus : MonoBehaviour
{
    // Start is called before the first frame update
    public enum PieceType
    {
       Ant,
       Beetle,
       GrassHopper,
       Spider,
       QueenBee
    }
    public enum Team
    {
        White,
        Black
    }

    public PieceType thisPiece;
    public Team thisTeam;

    public Material blackMaterial;

    public TextMesh TempLabel;
    void Start()
    {
        //Find the temp lable for display
        TempLabel = transform.Find("TempLabel").GetComponent<TextMesh>();
        switch (thisPiece)
        {
            case PieceType.Ant:
                TempLabel.text = "Ant";
                break;
            case PieceType.Beetle:
                TempLabel.text = "Beetle";
                break;
            case PieceType.GrassHopper:
                TempLabel.text = "GrassHopper";
                break;
            case PieceType.Spider:
                TempLabel.text = "Spider";
                break;
            case PieceType.QueenBee:
                TempLabel.text = "Queen Bee";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Set the type of piece for movement rules 
    /// </summary>
    /// <param name="pt"> Must set the enum PieceType.  Can be Ant,Beetle,Grasshopper,Spider,QueenBee</param>
    public void SetPeiceType(PieceType pt)
    {
        thisPiece = pt;
        //Get label and set the text to match the piece type
        TempLabel = transform.Find("TempLabel").GetComponent<TextMesh>();
        switch (pt)
        {
            case PieceType.Ant:
                TempLabel.text = "Ant";
                break;
            case PieceType.Beetle:
                TempLabel.text = "Beetle";
                break;
            case PieceType.GrassHopper:
                TempLabel.text = "GrassHopper";
                break;
            case PieceType.Spider:
                TempLabel.text = "Spider";
                break;
            case PieceType.QueenBee:
               TempLabel.text = "Queen Bee";
                break;
        }

    }
    /// <summary>
    /// Set the team of the piece.
    /// </summary>
    /// <param name="team">Must set as enum of Team. Can be white or black.</param>
    public void SetTeam(Team team)
    {
        thisTeam = team;
        //Change Peice Color (to be added)
        if(thisTeam == Team.Black)
        {
            GetComponentInChildren<MeshRenderer>().material = blackMaterial;
            TempLabel = transform.Find("TempLabel").GetComponent<TextMesh>();
            TempLabel.color = Color.white;
        }
        
    }
    private void OnMouseEnter()
    {
        //  meshRend.material.color = Color.red;
        Debug.Log("Mouse Enter Detected");
    }

    private void OnMouseExit()
    {
        //meshRend.material.color = Color.white;
        /**    if(pieceStatus.thisTeam == GamePieceStatus.Team.White) {
                meshRend.material.color = Color.white;
            }
            else
            {
                meshRend.material = pieceStatus.blackMaterial;
            }**/
    }
}
