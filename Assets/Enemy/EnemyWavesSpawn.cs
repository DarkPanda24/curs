using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWavesSpawn : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        for (int i = 0; i < hazardCount; i++)
        {
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(hazard, spawnValues, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
