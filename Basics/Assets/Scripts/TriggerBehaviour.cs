using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    public FloatData data;
    
    private void OnTriggerEnter(Collider other)
    {
        data.UpdateValue( number: -.1f);
    }
}
