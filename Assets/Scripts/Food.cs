using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public string name;
    public int parametr1;
    public int parametr2;
    public int parametr3;

    public Collider col;
    public Rigidbody rg;
    public Material mat;

    public float x;
    void Start()
    {
        mat.color = Color.white;
        rg = GetComponent<Rigidbody>();
        col = GetComponent<MeshCollider>();
        //mat = GetComponent<Material>();

        x = transform.localScale.y / 10;
    }

    
    void Update()
    {
        if(BtnTimer.doDown == true)
        {
            col.isTrigger = true;
        }
        else
        {
            col.isTrigger = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ox")
        {
            mat.color = Color.green;
        }
        if (other.gameObject.tag == "press")
        {
            transform.localScale = new Vector3(transform.localScale.x, x, transform.localScale.z);
        }
    }

}
