using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerStayEvent;

    private void OnTriggerEvent(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        TriggerStayEvent.Invoke();
    }
    
}
