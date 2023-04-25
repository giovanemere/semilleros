using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public bool messagesDone;
    public GameObject[] messages;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < messages.Length; i++)
        {
            messages[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
            if (!PlayerManager.wasOnTutorial)
            {
                if (counter > 2 && !messagesDone)
                {
                    Finances.capital = 20000;
                    PlayerManager.canShowTip = true;
                    messagesDone = true;
                    Invoke("showQuestions", 5f);
                }
                else if (counter <= 2)
                {
                    messages[counter].SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        counter += 1;
                        for (int i = 0; i < messages.Length; i++)
                        {
                            if (i != counter)
                            {
                                messages[i].SetActive(false);
                            }
                        }
                    }
                }
            }
        }

    public void showQuestions()
    {
            PlayerManager.canShowQuestion = true;
    }
}
