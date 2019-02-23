using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public float startattackdeley;
    public float timeattackdeley;
    public float attackcounts;
    public float bulletcounts;
    float sattack;

    void Start()
    {
        sattack = Time.time + startattackdeley;
    }
    void Update()
    {
        if (sattack == Time.time)
        {
            
        }
    }
}
