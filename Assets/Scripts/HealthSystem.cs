using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    public int hp;
    public int p1;
    public int p2;
    public int p3;

    public int maxPoint;

    public TextMeshPro health;
    public TextMeshPro parametrText1;
    public TextMeshPro parametrText2;
    public TextMeshPro parametrText3;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetInformation()
    {
        health.text = hp.ToString();
        parametrText1.text = "Белки " + p1.ToString();
        parametrText2.text = "Жиры " + p2.ToString();
        parametrText3.text = "Углеводы " + p3.ToString();

    }
    public void CheckParametrs()
    {
        if(p1 <= 0 || p2 <= 0 || p3 <= 0)
        {
            hp--;
        }
        else
        {

        }
    }
    public void ParametrsAdd(GameObject food)
    {
        p1 += food.gameObject.GetComponent<Food>().parametr1;
        p2 += food.gameObject.GetComponent<Food>().parametr2;
        p3 += food.gameObject.GetComponent<Food>().parametr3;
        SetInformation();
    }

    public void ParametrsReduce()
    {
        p1 -= Random.Range(1, 3);
        p2 -= Random.Range(1, 3);
        p3 -= Random.Range(1, 3);
    }
}
