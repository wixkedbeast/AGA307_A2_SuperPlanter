using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text harvestAmountText;
    public TMP_Text currentToolText;
    public Slider dayNightCycleSlider;
    public TMP_Text timerText;
    
    public void UpdateHarvestAmount(int _Amount)
    {
        harvestAmountText.text = "Amount:" + _Amount;
        //changes harvest amount display in UI
    }

    public void UpdateTimer(float _timer)
    {
        timerText.text = "Time Remaining:" + _timer.ToString("F2");
        dayNightCycleSlider.value = _timer;
        //Changes timer when the sun rotation moves 
        
    }

    public void UpdateCurrentTool(string _currentTool)
    {
        
        currentToolText.text = _currentTool.ToString();
        

    }

   

    public void UpdateTool(GameObject tool)

    {

        currentToolText.text = tool.name.ToString();
        //shows current tool is UI display when a tool is changed 
    }


}
