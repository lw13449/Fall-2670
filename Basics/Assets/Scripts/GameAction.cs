using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
<<<<<<< Updated upstream
     public UnityAction action;
 
     public void Raise()
     {
         action.Invoke();
     }
 }
