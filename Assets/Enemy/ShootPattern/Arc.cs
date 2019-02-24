using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arc : MonoBehaviour
{
    public float speed = 10;
    public float arcHeight = 2;
    public GameObject enemy;
    public float DistanceFromPlayer, CoolDown1,CD1;
    public int AttackRadius;
    public GameObject instantiatedObj;
    public GameObject ProjectileGM;
    public Transform postitoncreate;
    private float CoolDown = 2f,CD = 0.2f;
    private Vector3 ShootDir;
    public float ShotSpeed;
    private Vector3 EnemyPos;
    private bool FL, FR;





    void Update()
    {
        if (enemy != null)
        {
            DistanceFromPlayer = Vector3.Distance(enemy.transform.position, this.gameObject.transform.position);
            if (DistanceFromPlayer <= AttackRadius)
            {
                Attack();
            }
        }
    }

    void Attack()
    {
        CoolDown -= Time.deltaTime;
        if (CoolDown <= 0)
        {
            EnemyPos = enemy.transform.position - transform.position;
            Debug.DrawLine(transform.position, enemy.transform.position, Color.yellow);
            ShotSpeed = Mathf.Sqrt(Mathf.Abs(EnemyPos.x) / 0.0781678003f);
            for (float i = -arcHeight; i < arcHeight; i += (float)0.2)
            {
                ShootDir = new Vector3(1.0f, 0, 0f);
                instantiatedObj = (GameObject)Instantiate(ProjectileGM, postitoncreate.position + new Vector3(i, (float)0.1 * Mathf.Pow(i,2)), transform.rotation);
                instantiatedObj.GetComponent<Rigidbody2D>().velocity = ShootDir * ShotSpeed * .80f;
                Destroy(instantiatedObj, 4);
            }
            CoolDown = CoolDown1;
        }
    }

    static Quaternion LookAt2D(Vector2 forward)
    {
        return Quaternion.Euler(0, 0, Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg);
    }
}
