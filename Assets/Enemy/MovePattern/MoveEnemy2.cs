using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    const double e = 2.71828182846;
    double espeed = 0;
    double x, y;
    public float speed;
    void Update()
    {
        x = Math.Cos(espeed) * 2 * Math.Pow(e, 2) * espeed;
        y = Math.Sqrt(Math.Sin(espeed) * Math.Pow(e, 3.7)) * espeed - 6;
        //float hiperspeed = -espeed * espeed + 5;
        transform.position = new Vector3((float)x, (float)y);
        if (transform.position.x < 10 && transform.position.x > -10)
        {
            espeed += speed;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
