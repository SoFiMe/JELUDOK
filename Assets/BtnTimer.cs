using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTimer : MonoBehaviour
{
    public float tmr;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(anim.GetBool("click") == true)
        {
            tmr += Time.deltaTime;
        }
        if(tmr >= 1)
        {
            anim.SetBool("click", false);
            tmr = 0;
        }

    }
}
