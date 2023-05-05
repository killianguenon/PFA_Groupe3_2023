using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float timer;
    ParameterAll parameterAll;
    void Start()
    {
        timer = parameterAll.timer;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            
        }
    }
}
