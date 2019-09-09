using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{

    public GameAction gameActionObj;
    public UnityEvent handlerEvent;
    
    void Start()
    {
        gameActionObj.action += gameActionObj()
        {
            handlerEvent.Invoke();
        }
    }
    
}
