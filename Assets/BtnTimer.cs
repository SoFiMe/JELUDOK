using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTimer : MonoBehaviour
{
    public float tmr;
    public Animator anim;
    public GameObject box;
    public bool da;
    public bool food;

    public static bool doDown = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (food)
        {
            if (anim.GetBool("click") == true)
            {
                tmr += Time.deltaTime;
            }
            if (tmr >= 1)
            {
                anim.SetBool("click", false);
                tmr = 0;
            }
        }
        if (da)
        {
            if (box.GetComponent<Animator>().GetBool("ox") == true)
            {
                tmr += Time.deltaTime;
            }
            if (tmr >= 4)
            {
                anim.SetBool("click", false);
                box.GetComponent<Animator>().SetBool("ox", false);
                tmr = 0;
            }
        }
        if (da)
        {
            if (box.GetComponent<Animator>().GetBool("press") == true)
            {
                tmr += Time.deltaTime;
            }
            if (tmr >= 4)
            {
                anim.SetBool("click", false);
                box.GetComponent<Animator>().SetBool("press", false);
                tmr = 0;
            }
        }
        if (da)
        {
            if (box.GetComponent<Animator>().GetBool("floor") == true)
            {
                tmr += Time.deltaTime;
                doDown = true;
            }
            if (tmr >= 4)
            {
                anim.SetBool("click", false);
                doDown = false;
                box.GetComponent<Animator>().SetBool("floor", false);
                tmr = 0;
            }
        }

    }
}
