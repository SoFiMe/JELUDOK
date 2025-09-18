using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FoodSystem : MonoBehaviour
{
    public string day;
    //public int dayInt;
    public static int saveday =1;
    public GameObject[] day1;
    public GameObject[] day2;
    public GameObject[] day3;
    public GameObject[] day4;
    public GameObject[] day5;
    public GameObject[] day6;
    public GameObject[] day7;
    public GameObject[] day8;
    public GameObject[] day9;

    public GameObject foodTablet;

    public GameObject[] foodUI;
    public TextMeshPro daytext;

    public bool foodIsSelected;
    public HealthSystem healthSystem;

    public GameObject[] humans;
    void Start()
    {
        if (saveday == 1)
        {
            healthSystem.FirstDay();
            day = "day" + saveday.ToString();
            daytext.text = "Δενό " + saveday;
            healthSystem.SetInformation();

        }
        else
        {
            healthSystem.Load();
            healthSystem.SetInformation();
            day = "day" + saveday.ToString();
            daytext.text = "Δενό " + saveday;           
        }
    }

    
    void Update()
    {
        Debug.Log(saveday);
        if(saveday >= 10)
        {
            SceneManager.LoadScene(2);
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
        if (day == nameof(day3))
        {
            return day3;
        }
        if (day == nameof(day4))
        {
            return day4;
        }
        if (day == nameof(day5))
        {
            return day5;
        }
        if (day == nameof(day6))
        {
            return day6;
        }
        if (day == nameof(day7))
        {
            return day7;
        }
        if (day == nameof(day8))
        {
            return day8;
        }
        if (day == nameof(day9))
        {
            return day9;
        }
        return day1;
    }
}
