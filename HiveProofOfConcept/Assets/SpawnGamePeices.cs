using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGamePeices : MonoBehaviour
{
    //Spawn game pieces for the game
    //Each team gets   3 ants, 2 beetles, 3 grasshopper, 2 spiders, 1 queen bee
    public GameObject piecePrefab;

    public GameObject[] WhiteTeam = new GameObject[11];
    public GameObject[] BlackTeam = new GameObject[11];

    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            if (i == 0)
            {
                //Spawn Queen Bee
                GameObject GOW = Instantiate(piecePrefab,new Vector3(-.88f,0,i),Quaternion.identity);
                GOW.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.QueenBee);
                GOW.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.White);
                GOW.name = "QueenBee (White)";
                WhiteTeam[i] = GOW;

                GameObject GOB = Instantiate(piecePrefab,new Vector3(-1.76f,i),Quaternion.identity);
                GOB.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.QueenBee);
                GOB.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.Black);
                GOB.name = "QueenBee (Black)";
                BlackTeam[i] = GOB;
            }
            if(i==1 || i == 2  || i==3)
            {
                //Spawn Ants
                GameObject GOW = Instantiate(piecePrefab, new Vector3(-.88f, 0, i), Quaternion.identity); ;
                GOW.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.Ant);
                GOW.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.White);
                GOW.name = "Ant (White)";
                WhiteTeam[i] = GOW;

                GameObject GOB = Instantiate(piecePrefab, new Vector3(-1.76f, 0, i), Quaternion.identity); ;
                GOB.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.Ant);
                GOB.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.Black);
                GOB.name = "Ant (Black)";
                BlackTeam[i] = GOB;
            }
            if(i==4 || i == 5)
            {
                //Spawn Beetles
                GameObject GOW = Instantiate(piecePrefab, new Vector3(-.88f, 0, i), Quaternion.identity); ;
                GOW.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.Beetle);
                GOW.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.White);
                GOW.name = "Beetle (White)";
                WhiteTeam[i] = GOW;

                GameObject GOB = Instantiate(piecePrefab, new Vector3(-1.76f, 0, i), Quaternion.identity); ;
                GOB.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.Beetle);
                GOB.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.Black);
                GOB.name = "Beetle (Black)";
                BlackTeam[i] = GOB;
            }
            if(i==6 || i==7 || i == 8)
            {
                //Spawn Grasshopers
                GameObject GOW = Instantiate(piecePrefab, new Vector3(-.88f, 0, i), Quaternion.identity); ;
                GOW.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.GrassHopper);
                GOW.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.White);
                GOW.name = "GrassHopper (White)";
                WhiteTeam[i] = GOW;

                GameObject GOB = Instantiate(piecePrefab, new Vector3(-1.76f, 0, i), Quaternion.identity); ;
                GOB.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.GrassHopper);
                GOB.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.Black);
                GOB.name = "Grasshopper (Black)";
                BlackTeam[i] = GOB;
            }
            if( i==9 || i==10)
            { 
                //Spawn Spiders
                GameObject GOW = Instantiate(piecePrefab, new Vector3(-.88f, 0, i), Quaternion.identity); ;
                GOW.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.Spider);
                GOW.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.White);
                GOW.name = "Spider (White)";
                WhiteTeam[i] = GOW;

                GameObject GOB = Instantiate(piecePrefab, new Vector3(-1.76f, 0, i), Quaternion.identity); ;
                GOB.GetComponentInChildren<GamePieceStatus>().SetPeiceType(GamePieceStatus.PieceType.Spider);
                GOB.GetComponentInChildren<GamePieceStatus>().SetTeam(GamePieceStatus.Team.Black);
                GOB.name = "Spider (Black)";
                BlackTeam[i] = GOB;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
