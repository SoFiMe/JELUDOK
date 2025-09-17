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
    public Proccesor proccesor;

    public string ButtonType;
    public Animation a;
    public float timer;

    public GameObject spawnPoint;
    public GameObject box;
    public bool foodOnScene;
    public bool go;

    private void Update()
    {
        InteractionWithButton();
    }
    private void InteractionWithButton()
    {
        if (!Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out RaycastHit hit, interactionDistance, buttonLayer)) return;

        if(hit.collider.gameObject.name == "FoodButton")
        {
            if (Input.GetMouseButtonDown(0) )
            {
                if ((foodOnScene == false))
                {
                    foodSystem.GiveFoodToTheTable();
                    hit.collider.gameObject.GetComponent<Animator>().SetBool("click", true);
                    sounds.PlayLever();
                    proccesor.Ready();
                    proccesor.SetInfo();
                    foodOnScene = true;
                    go = true;
                }
            }
        }
        if (go)
        {
            if (hit.collider.gameObject.name == "ChooseButton1")
            {
                if (Input.GetMouseButtonDown(0) && foodSystem.foodIsSelected == false)
                {
                    Debug.Log("Выбрал 1");
                    hit.collider.gameObject.GetComponent<Animator>().SetBool("click", true);
                    healthSystem.ParametrsAdd(foodSystem.GetCurrentArray()[0]);
                    Instantiate(foodSystem.GetCurrentArray()[0], spawnPoint.transform);
                    sounds.PlayButton();
                    foodSystem.foodIsSelected = true;

                }
            }
            if (hit.collider.gameObject.name == "ChooseButton2")
            {
                if (Input.GetMouseButtonDown(0) && foodSystem.foodIsSelected == false)
                {
                    Debug.Log("Выбрал 2");
                    hit.collider.gameObject.GetComponent<Animator>().SetBool("click", true);
                    healthSystem.ParametrsAdd(foodSystem.GetCurrentArray()[1]);
                    Instantiate(foodSystem.GetCurrentArray()[1], spawnPoint.transform);
                    sounds.PlayButton();
                    foodSystem.foodIsSelected = true;
                }
            }
            if (hit.collider.gameObject.name == "ChooseButton3")
            {
                if (Input.GetMouseButtonDown(0) && foodSystem.foodIsSelected == false)
                {
                    Debug.Log("Выбрал 3");
                    hit.collider.gameObject.GetComponent<Animator>().SetBool("click", true);
                    healthSystem.ParametrsAdd(foodSystem.GetCurrentArray()[2]);
                    Instantiate(foodSystem.GetCurrentArray()[2], spawnPoint.transform);
                    sounds.PlayButton();
                    foodSystem.foodIsSelected = true;
                }
            }
            if (foodOnScene)
            {
                if (hit.collider.gameObject.name == "OxBut")
                {
                    if ((Input.GetMouseButtonDown(0)))
                    {
                        hit.collider.gameObject.GetComponent<Animator>().SetBool("click", true);
                        box.gameObject.GetComponent<Animator>().SetBool("ox", true);
                        sounds.PlayPress();
                        proccesor.oxIsReady = true;
                    }
                }
                if (hit.collider.gameObject.name == "PressBut")
                {
                    if ((Input.GetMouseButtonDown(0)))
                    {
                        hit.collider.gameObject.GetComponent<Animator>().SetBool("click", true);
                        box.gameObject.GetComponent<Animator>().SetBool("press", true);
                        sounds.PlayPress();
                        proccesor.pressIsReady = true;
                    }
                }
                if (hit.collider.gameObject.name == "FloorBut")
                {
                    if ((Input.GetMouseButtonDown(0)))
                    {
                        if (proccesor.pressIsReady == true && proccesor.oxIsReady == true)
                        {
                            hit.collider.gameObject.GetComponent<Animator>().SetBool("click", true);
                            box.gameObject.GetComponent<Animator>().SetBool("floor", true);
                            sounds.PlayComplete();
                        }
                    }
                }
            }
            
        }
        
    }
}
