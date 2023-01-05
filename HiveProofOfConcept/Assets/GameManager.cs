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
    public GameObject hoveredObject;

    public GameObject TempObjectForTesting;
    private float clickTime =0.0f;
    private float clickDelay = 0.3f;

    public float mouseOffset = 2.0f;
    Vector3 pos;

    public LayerMask rayLM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            clickTime = Time.time;
                if (pickedUpObject == null)
                {
                pickedUpObject = hoveredObject;
                hoveredObject = null;
                }
                else if (pickedUpObject != null)
                {
                pos = pickedUpObject.transform.position;
                pos.y = 0.0f;
                pickedUpObject.transform.position = pos;
                dropPickupObject();
                }
        }

        if (pickedUpObject != null)
        {
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray,out hit, 10f, rayLM))
        {
            Transform objectHit = hit.transform;
            pickedUpObject.transform.position = objectHit.transform.position;
        }
        pickedUpObject = null;
    }
   
}
