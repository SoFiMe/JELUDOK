using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

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
        SetInformation();
    }

    void Update()
    {
        
    }

    public void SetInformation()
    {
        string result = string.Concat(Enumerable.Repeat("[]", hp));
        health.text = "Здоровье " + result;
        result = string.Concat(Enumerable.Repeat("[]", p1));
        parametrText1.text = "Белки " + result;
        result = string.Concat(Enumerable.Repeat("[]", p2));
        parametrText2.text = "Жиры " + result;
        result = string.Concat(Enumerable.Repeat("[]", p3));
        parametrText3.text = "Углеводы " + result;

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
        if(p1 > maxPoint)
        {
            p1 = maxPoint;
        }
        p2 += food.gameObject.GetComponent<Food>().parametr2;
        if (p2 > maxPoint)
        {
            p2 = maxPoint;
        }
        p3 += food.gameObject.GetComponent<Food>().parametr3;
        if (p3 > maxPoint)
        {
            p3 = maxPoint;
        }
        if(hp > maxPoint)
        {
            hp = maxPoint;
        }
        SetInformation();
    }

    public void ParametrsReduce()
    {
        p1 -= Random.Range(1, 3);
        p2 -= Random.Range(1, 3);
        p3 -= Random.Range(1, 3);
    }
}
