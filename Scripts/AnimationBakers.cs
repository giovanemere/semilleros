using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBakers : MonoBehaviour
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
        if (InterfaceData.products>0)
        {
            if (Id==1)
            {
                anim.SetInteger("States", 1);//hablarmujer
            }
            else if (Id == 2)
            {
                anim.SetInteger("States", 2);//teclear
            }
            else if (Id == 3)
            {
                anim.SetInteger("States", 3);//parad0o
            }
        }
        else
        {
            anim.SetInteger("States", 0);//sentado
        }
    }
}
