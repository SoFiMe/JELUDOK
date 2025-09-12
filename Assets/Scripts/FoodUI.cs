using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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


    void Start()
    {
        SetInformationToText();
    }

    
    void Update()
    {
        
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
        parametrText1.text = "Белки " + parametr1.ToString();
        parametrText2.text = "Жиры " + parametr2.ToString();
        parametrText3.text = "Углеводы " + parametr3.ToString();

    }

}
