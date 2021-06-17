using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beatmap : MonoBehaviour

{
    public GameObject[] Arrows;
    public float[] arrowUpTempo, arrowDownTempo, arrowLeftTempo, arrowRightTempo;
    public int arrowUpCounter, arrowDownCounter, arrowLeftCounter, arrowRightCounter;

    void Start()
    {
        StartCoroutine(ArrowSpawnerUp());
    }

    IEnumerator ArrowSpawnerUp()
    {
        do
        {
            yield return new WaitForSeconds(arrowUpTempo[arrowUpCounter]);
            Instantiate(Arrows[0], Arrows[0].transform.position, Arrows[0].transform.rotation);
            arrowUpCounter++;

        }
        while (arrowUpCounter < arrowUpTempo.Length);
    }

}
