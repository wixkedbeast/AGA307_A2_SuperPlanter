using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tools : MonoBehaviour
{
    public GameObject[] tools; 

    public int currentTool = 0;

    private int nrTools;

    void Start()
    {

        nrTools = tools.Length;

        SwitchTool(currentTool);

    }

    void Update()
    {
        for (int i = 1; i <= nrTools; i++)
        {
            if (Input.GetKeyDown("" + i))
            {
                currentTool = i - 1;

                SwitchTool(currentTool);

            }
        }

    }

    void SwitchTool(int index)
    {

        for (int i = 0; i < nrTools; i++)
        {
            if (i == index)
            {
                tools[i].gameObject.SetActive(true);
            }
            else
            {
                tools[i].gameObject.SetActive(false);
            }
        }
    }
    

     
      
  
}
