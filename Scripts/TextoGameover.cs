using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoGameover : MonoBehaviour
{
    public static bool iscapitalgameover,wasshown;
    public Text Losequestions, totalLose,score;
    // Start is called before the first frame update
    void Start()
    {
        if (iscapitalgameover)
        {
            totalLose.enabled = true;
            Losequestions.enabled = false;
            score.text = PlayerManager.score.ToString();
        }
        else
        {
            totalLose.enabled = false;
            Losequestions.enabled = true;
        }
        wasshown = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
