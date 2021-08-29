using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
   

    private void OnMouseDown()
    {
        GameManager.currentTool = "clippers";
        Debug.Log(GameManager.currentTool);
    }
}
