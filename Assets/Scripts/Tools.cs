using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tools : MonoBehaviour
{
    public GameObject[] tools; 
    public UIManager ui;
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
                GameManager.currentTool = tools[currentTool].name;
                ui.UpdateTool(tools[currentTool]);
                //allows player to change tool and it to show up in the UI display
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
