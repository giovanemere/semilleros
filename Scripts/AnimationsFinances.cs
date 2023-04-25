using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsFinances : MonoBehaviour
{
    public Animator anim;
    public int Id;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Id == 1)
        {
            anim.SetInteger("States", 7);//hablarmujer
        }
        else if (Id == 2)
        {
            anim.SetInteger("States", 4);//teclear
        }
        else if (Id == 3 || Id == 4)
        {
            anim.SetInteger("States", 0);//parad0o
        }
        else
        {
            anim.SetInteger("States", 2);//sentado
        }
    }
}
