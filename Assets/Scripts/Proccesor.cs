using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Proccesor : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] whatNeed;
    public bool ox = false;
    public bool press = false;

    public bool oxIsReady;
    public bool pressIsReady;

    public TextMeshPro text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ready()
    {
        int x = Random.Range(0, 2);
        if(x == 1)
        {
            ox = true;
            oxIsReady = false;
        }
        int y = Random.Range(0, 2);
        if (y == 1)
        {
            press = true;
            pressIsReady = false;
        }
        if(x == 0 && y == 0)
        {
            press = true;
            pressIsReady = false;
        }
    }
    public void SetInfo()
    {
        if (ox)
        {
            text.text = whatNeed[0];
        }
        if (press)
        {
            text.text = whatNeed[1];
        }
        if(ox && press)
        {
            text.text = whatNeed[2];
        }
    }
}
