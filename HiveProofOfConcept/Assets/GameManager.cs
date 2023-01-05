using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //May change to a signleton later

    //Main/Master script to controll the state of the game
    //
    // Start is called before the first frame update

    public GameObject pickedUpObject;
    //Reporting object to indicate hovered object.
    public GameObject hoveredObject;

    public GameObject TempObjectForTesting;
    private float clickTime =0.0f;
    private float clickDelay = 0.3f;

    public float mouseOffset = 2.0f;
    Vector3 pos;

    //Layer mask for raycast from pointer postion on screen
    public LayerMask rayLM;
    void Start()
    {
        //Mask to make sure ray only hits the map objects
        rayLM = LayerMask.GetMask("Map");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //Check for button click and inlcuded bounce time
            clickTime = Time.time;
                if (pickedUpObject == null)
                {
                    pickedUpObject = hoveredObject;
                    hoveredObject = null;
                }
                else if (pickedUpObject != null)
                {
                    dropPickupObject();
                }
        }

        if (pickedUpObject != null)
        {
            //Translate pointer postion and have picked up object follow it
            pos = Input.mousePosition;
            Debug.Log(pos);
            Debug.Log(Camera.main.ScreenToWorldPoint(pos));
            pos.z = mouseOffset;
            
            pickedUpObject.transform.position = Camera.main.ScreenToWorldPoint(pos);
        }
    }
/// <summary>
/// Sets the pickedUp object
/// </summary>
/// <param name="go"></param>
    public void SetPickUpObject(GameObject go)
    {
        if(pickedUpObject == null)
        {
            pickedUpObject = go;
        }
        else
        {
            Debug.Log("Object already pickedup.  Need to call drop object first)");
        }
        
    }
    /// <summary>
    /// Get the pickupObject
    /// </summary>
    /// <returns>Returns currently pickedUpObject or null if nothing is picked up</returns>
    public GameObject GetPickupObject()
    {
        if (pickedUpObject != null)
        {
            return pickedUpObject;
        }
        else
        {
            return null;
        }
    }
    /// <summary>
    /// Drop current pickupObject
    /// </summary>
    public void dropPickupObject()
    {
        RaycastHit hit;
        //Ray out from the pointer locaiton on the screen
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Ray cast from the pointer on screen to search for map location
        if(Physics.Raycast(ray,out hit, 10f, rayLM))
        {
            Transform objectHit = hit.transform;
            //Place game Piece on to the map at desired location
            pickedUpObject.transform.position = objectHit.transform.position;
        }
        //clear out pickup object
        pickedUpObject = null;
    }
   
}
