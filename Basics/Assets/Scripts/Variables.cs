using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Variables : MonoBehaviour
{

    public GameAction sleepfunction;
    public UnityEvent sleeping;
    public bool asleep;

    private void Start()
    {
        sleepfunction.action += Action;
    }

    
    private void Action()
    {
        sleeping.Invoke();
        print("Player is asleep");
    }
}
