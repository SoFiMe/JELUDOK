using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class FoodUI : MonoBehaviour
{
    public string name;
    public int parametr1;
    public int parametr2;
    public int parametr3;


    public TextMeshPro nameText;
    public TextMeshPro parametrText1;
    public TextMeshPro parametrText2;
    public TextMeshPro parametrText3;

    public FoodSystem foodSystem;


    void Start()
    {
        CleanConsole();
    }

    
    void Update()
    {
        if (foodSystem.foodIsSelected)
        {
            CleanConsole();
        }
    }
    public void GetFoodInformation(GameObject food)
    {
        
        name = food.GetComponent<Food>().name;
        parametr1 = food.GetComponent<Food>().parametr1;
        parametr2 = food.GetComponent<Food>().parametr2;
        parametr3 = food.GetComponent<Food>().parametr3;
    }
    public void SetInformationToText()
    {
        nameText.text = name;
        string result1 = string.Concat(Enumerable.Repeat("[]", parametr1));
        parametrText1.text = "Белки " + result1;
        result1 = string.Concat(Enumerable.Repeat("[]", parametr2));
        parametrText2.text = "Жиры " + result1;
        result1 = string.Concat(Enumerable.Repeat("[]", parametr3));
        parametrText3.text = "Углеводы " + result1;
    }
    public void CleanConsole()
    {
        nameText.text = "";
        parametrText1.text = "";
        parametrText2.text = "";
        parametrText3.text = "";
    }

}
