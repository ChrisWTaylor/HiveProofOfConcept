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
    public void SetPeiceType(PieceType pt)
    {
        thisPiece = pt;
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

    public void SetTeam(Team team)
    {
        thisTeam = team;
        //Change Peice Color (to be added)
    }
}
