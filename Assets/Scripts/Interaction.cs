using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject playerCamera;
    public float interactionDistance;
    public LayerMask buttonLayer;

    private void Update()
    {
        InteractionWithButton();
    }
    private void InteractionWithButton()
    {
        if (!Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out RaycastHit hit, interactionDistance, buttonLayer)) return;

        Debug.Log("Кнопка");
    }
}
