using UnityEngine;
using System.Collections;


public class movePlayer : MonoBehaviour
{
    public float hspeed = 3f;
    public float vspeed = 1f;
    public Animator anim;

    void Update()
    {
        float hspeedn = hspeed;
        float vspeedn = vspeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            vspeedn = vspeedn / 2;
            hspeedn = hspeedn / 2;
        }
        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(hspeedn * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= new Vector3(hspeedn * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow))
           transform.position -= new Vector3(0, vspeedn * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.UpArrow) )
           transform.position += new Vector3(0, vspeedn * Time.deltaTime, 0);
    }
}