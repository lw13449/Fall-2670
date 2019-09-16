using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Variables : MonoBehaviour
{

    public GameAction sleepfunction;
    public UnityEvent sleeping;

    private void Start()
    {
        sleepfunction.action += Action;
    }

    
    private void Action()
    {
        sleeping.Invoke();
    }
}
