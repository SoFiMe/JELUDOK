using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSystem : MonoBehaviour
{
    public string day;
    public int dayInt;
    public GameObject[] day1;
    public GameObject[] day2;

    public GameObject foodTablet;

    public GameObject[] foodUI;

    public bool foodIsSelected;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            dayInt++;
            day = "day" + dayInt.ToString();
        }
    }
    public void GiveFoodToTheTable()
    {
        foodUI[0].GetComponent<FoodUI>().GetFoodInformation(GetCurrentArray()[0]);
        foodUI[0].GetComponent<FoodUI>().SetInformationToText();
        foodUI[1].GetComponent<FoodUI>().GetFoodInformation(GetCurrentArray()[1]);
        foodUI[1].GetComponent<FoodUI>().SetInformationToText();
        foodUI[2].GetComponent<FoodUI>().GetFoodInformation(GetCurrentArray()[2]);
        foodUI[2].GetComponent<FoodUI>().SetInformationToText();
    }
    public GameObject[] GetCurrentArray()
    {
        if(day == nameof(day1))
        {
            return day1;
        }
        if (day == nameof(day2))
        {
            return day2;
        }
        return day1;
    }
}
