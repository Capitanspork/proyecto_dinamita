using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefab;
    private int spawnIndex;
    private Transform[] spawnpoints;
    private Vector3 spawnPos;
    private int count;

    public static EffectSpawner instance;

    void Start()
    {
        instance = this;
        count = transform.childCount;
        spawnpoints = new Transform[count];
        for (int i = 0; i < count; i++)
        {
            spawnpoints[i] = transform.GetChild(i);
        }


    }

    public void spawnPrefab(int note)
    {
        spawnIndex = Random.Range(0, count);

        Instantiate(prefab[note], spawnpoints[spawnIndex].position, prefab[note].transform.rotation);
    }


}

