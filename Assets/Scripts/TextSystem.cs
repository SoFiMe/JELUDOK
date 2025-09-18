using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSystem : MonoBehaviour
{
    public FoodSystem day;
    [TextArea(3, 10)]
    public string[] messages;
    public TextMeshPro text;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = messages[FoodSystem.saveday];
    }
}
