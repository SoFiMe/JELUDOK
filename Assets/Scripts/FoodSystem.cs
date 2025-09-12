using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSystem : MonoBehaviour
{
    public int day;
    public GameObject[] foodarray1;

    public GameObject foodTablet;

    public GameObject[] foodUI;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void GiveFoodToTheTable()
    {
        foodUI[0].GetComponent<FoodUI>().GetFoodInformation(foodarray1[0]);
        foodUI[0].GetComponent<FoodUI>().SetInformationToText();
        foodUI[1].GetComponent<FoodUI>().GetFoodInformation(foodarray1[0]);
        foodUI[1].GetComponent<FoodUI>().SetInformationToText();
        foodUI[2].GetComponent<FoodUI>().GetFoodInformation(foodarray1[0]);
        foodUI[2].GetComponent<FoodUI>().SetInformationToText();

    }
}
