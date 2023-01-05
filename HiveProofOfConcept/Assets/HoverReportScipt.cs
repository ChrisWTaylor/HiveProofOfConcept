using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverReportScipt : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer meshRender;
    private GamePieceStatus pieceStatus;

    private GameManager gm;
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
        pieceStatus = transform.parent.GetComponent<GamePieceStatus>();
        gm = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        //Set color to red on hover
        meshRender.material.color = Color.red;
        gm.hoveredObject = transform.parent.gameObject;
    }
    private void OnMouseExit()
    {
        //Reset color of highlighted Object to orginal based on team
        if(pieceStatus.thisTeam == GamePieceStatus.Team.White)
        {
            meshRender.material.color = Color.white;
        }
        else
        {
            meshRender.material = pieceStatus.blackMaterial;
        }
        gm.hoveredObject = null;
    }
}
