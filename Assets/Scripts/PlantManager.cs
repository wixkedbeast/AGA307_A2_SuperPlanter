using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlantManager : MonoBehaviour
{
    bool isPlanted = false;
    public UIManager ui;
    public GameManager _GM;
    public int harvestAmount;
    public GameObject[] plantStages;
    int plantStage = 0;
    float timeBtwStages = 2f;
    float timer;
    public bool isWatered = false;
    public GameObject plant;
    public bool harvestable = false;
    
    

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
                //when plant is watered it starts growing
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
           //when plant fully grown it is ready for harvest
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
                //plants seed when seeds tool is selected on soil piece
            }
        }

        if (GameManager.currentTool == "Watering Can")
        {
            if (isPlanted == true)
            {
                isWatered = true;
                //waters seed after seed has been planted
            }
        }

        if (GameManager.currentTool == "Clippers")
        {
            if (harvestable == true)
            {
                isPlanted = false;
                plantStages[plantStage].SetActive(false);
                plantStage = 0;
                _GM.harvestAmount++;
                ui.UpdateHarvestAmount(_GM.harvestAmount);
                //collects plant once it is fully grown
            }
            
        }

    }


    
}
