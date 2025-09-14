using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject playerCamera;
    public float interactionDistance;
    public LayerMask buttonLayer;

    public FoodSystem foodSystem;
    public HealthSystem healthSystem;
    public Sounds sounds;

    public string ButtonType;

    

    private void Update()
    {
        InteractionWithButton();
    }
    private void InteractionWithButton()
    {
        if (!Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out RaycastHit hit, interactionDistance, buttonLayer)) return;

        if(hit.collider.gameObject.name == "FoodButton")
        {
            if (Input.GetMouseButtonDown(0))
            {
                foodSystem.GiveFoodToTheTable();
                sounds.PlayButton();
            }
        }
        if(hit.collider.gameObject.name == "ChooseButton1")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Выбрал 1");
                healthSystem.ParametrsAdd(foodSystem.GetCurrentArray()[0]);
                Instantiate(foodSystem.GetCurrentArray()[0]);
                sounds.PlayButton();

            }
        }
        if (hit.collider.gameObject.name == "ChooseButton2")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Выбрал 2");
                healthSystem.ParametrsAdd(foodSystem.GetCurrentArray()[1]);
                sounds.PlayButton();
            }
        }
        if (hit.collider.gameObject.name == "ChooseButton3")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Выбрал 3");
                healthSystem.ParametrsAdd(foodSystem.GetCurrentArray()[2]);
                sounds.PlayButton();
            }
        }
    }
}
