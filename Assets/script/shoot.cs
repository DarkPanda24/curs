using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject BulPF;
    public float deleyFire;
    float shootnow = 0f;
    void Update()
    {
        if ((Input.GetKey(KeyCode.Z)) && (shootnow <= Time.time || shootnow == 0f))
        {
            SoundManagerScript.PlaySounnd("fire");
            shootnow = deleyFire + Time.time;
            Shooting();

        }
    }
    void Shooting()
    {
        Instantiate(BulPF, firepoint.position, firepoint.rotation);
    }
}
