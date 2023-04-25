using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timeText,dayText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        PlayerManager.OnMinuteChanged += UpdateTime;
        PlayerManager.OnHourChanged += UpdateTime;
    }
    private void OnDisable()
    {
        PlayerManager.OnMinuteChanged -= UpdateTime;
        PlayerManager.OnHourChanged -= UpdateTime;
    }
    private void UpdateTime() 
    {
        timeText.text = $"{PlayerManager.Hour:00}:{PlayerManager.Minute:00}";
        dayText.text = $"{PlayerManager.Day:00}/{PlayerManager.Month:00}/{PlayerManager.Year:00}";
    }
}
