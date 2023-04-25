using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employees : MonoBehaviour
{
    private int age, level, salary;
    private string _name, area;
    private bool isActive;

    public Employees() { }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Area
    {
        get { return area; }
        set { area = value; }
    }
    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public bool IsActive 
    {
        get { return isActive; }
        set { isActive = value; }
    }

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
