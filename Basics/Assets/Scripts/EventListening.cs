using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListening : MonoBehaviour
{
    private UnityEvent mouseClickEvent = new UnityEvent();
    public UnityEvent configuredMouseEvent;

    private void Start()
    { 
        mouseClickEvent.AddListener(MouseClick);
    }

    private void MouseClick()
    {
        configuredMouseEvent.Invoke();
        mouseClickEvent.RemoveListener(MouseClick);
    }

    private void OnMouseDown()
    {
        mouseClickEvent.Invoke();
    }
}
