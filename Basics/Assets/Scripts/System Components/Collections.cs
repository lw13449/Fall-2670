using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collections : ScriptableObject
{
    public List<Object> objectList;

    public List<FloatData> FloatDatas;

    public List<GameObject> gameObjects;

    public void FindObjectType(Object obj)
    {
        foreach (var currentObj in objectList)
        {
            if (currentObj == obj)
            {
                //Do Work-Instanciate, adding object, etc;
            }
        }
    }

    public void AddToList(Object obj)
    {
        objectList.Add(obj);
    }

    public void RemoveFromList(Object obj)
    {
        foreach (var currentObj in objectList)
        {
            if (currentObj == obj)
            {
                objectList.Remove(obj);
            }
        }
    }
}
