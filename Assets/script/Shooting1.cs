using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting1 : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public RaycastHit2D hitInfo;
    public LayerMask whatIsSolid;
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }


    void Update()
    {
        hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider.CompareTag("Enemy"))
        {
            Destroy(hitInfo.collider.gameObject);
            DestroyProjectile();
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
