using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowTutoriasQuestions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerManager.wasOnTutorial)
        {
            PlayerManager.canShowTip = true;
            Invoke("showQuestions", 10f);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void showQuestions()
    {
        PlayerManager.canShowQuestion = true;
        
    }
}
