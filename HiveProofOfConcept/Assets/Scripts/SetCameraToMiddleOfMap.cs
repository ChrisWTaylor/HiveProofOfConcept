using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraToMiddleOfMap : MonoBehaviour
{
    //Set Camera to point at the middle of the map
    //reference to Generate map to acces the Map Array so we can find the middle of the map
    private GenerateMap GenMap;

    //reference to camera
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
        GenMap = FindObjectOfType<GenerateMap>();
        //Get postition from the middle of the map
        Vector3 TempPost = GenMap.maptiles[GenMap.maptiles.GetLength(0) / 2, GenMap.maptiles.GetLength(1) / 2].transform.position;
        TempPost.y += 5.0f;
        
        cam.transform.position = TempPost;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
