using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Perehod : MonoBehaviour
{
    public Image img;
    public float timer;
    public float cd;

    public bool isStart;
    public bool isEnd;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("start", true);

    }

    public void TheEnd()
    {
        anim.SetBool("end", true);
    }
    public void dadaEnd()
    {
        TheEnd();
        Invoke("Next", 6f);
    }
    public void Next()
    {
        SceneManager.LoadScene(0);
    }


}
