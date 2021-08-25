using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantControl : MonoBehaviour
{
    public GameObject noPlantObj;
    public GameObject plantStage1;
    public GameObject plantStage2;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("clicked on weed");

        if(GameManager.currentTool == "clippers")
        {
            GetComponent<MeshRenderer>().material= noPlantObj;
        }

        if (GameManager.currentTool == "seeds") && (GetComponent<MeshRenderer>().material == noPlantObj));
        {
            GetComponent<MeshRenderer>().material= plantStage1;
        }
    }
}
