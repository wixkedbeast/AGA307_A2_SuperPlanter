using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlantManager : MonoBehaviour
{
    bool isPlanted = false;
    public UIManager ui;
    public int harvestAmount;
    public GameObject[] plantStages;
    int plantStage = 0;
    float timeBtwStages = 2f;
    float timer;
    public bool isWatered = false;
    public GameObject plant;
    public bool harvestable = false;
    public int amount;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = timeBtwStages;
        isWatered = false;
        isPlanted = false;
        plantStage = 0;
        plant = plantStages[plantStage];
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(isWatered && !harvestable)
        {
            timer -= Time.deltaTime;

            if (timer < 0 && plantStage <plantStages.Length- 1)
            {
                timer = timeBtwStages;
                plantStage++;
                UpdatePlant();
            }
        }
    }

    
    
   
    

    void UpdatePlant()
    {
        plant.SetActive(false);
        plant = plantStages[plantStage];
        plant.SetActive(true);
        if(plantStage == plantStages.Length - 1)
        {
            harvestable = true;

        }
    }



    void OnMouseDown()
    {
        if(GameManager.currentTool == "Seeds")
        {
            if(isPlanted == false)
            {
                isPlanted = true;
                plantStage = 0;
                UpdatePlant();
                print("PLANTED SEED");
            }
        }

        if (GameManager.currentTool == "Watering Can")
        {
            if (isPlanted == true)
            {
                isWatered = true;
            }
        }

        if (GameManager.currentTool == "Clippers")
        {
            if (harvestable == true)
            {
                isPlanted = false;
                plantStages[plantStage].SetActive(false);
                plantStage = 0;
                
            }
        }

    }

    
}
