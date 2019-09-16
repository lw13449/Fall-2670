﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBooster : MonoBehaviour
{
    public FloatData speed ;
   
    private void Update()
    {
        var speedVector = new Vector3(speed.value, 0, 0)*Time.deltaTime;
        transform.Translate(speedVector);

    }

}
