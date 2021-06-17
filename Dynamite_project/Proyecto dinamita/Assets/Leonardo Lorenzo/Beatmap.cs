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
        StartCoroutine(ArrowSpawnerDown());
        StartCoroutine(ArrowSpawnerLeft());
        StartCoroutine(ArrowSpawnerRight());
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

    IEnumerator ArrowSpawnerDown()
    {
        do
        {
            yield return new WaitForSeconds(arrowDownTempo[arrowDownCounter]);
            Instantiate(Arrows[1], Arrows[1].transform.position, Arrows[1].transform.rotation);
            arrowDownCounter++;

        }
        while (arrowDownCounter < arrowDownTempo.Length);
    }

    IEnumerator ArrowSpawnerLeft()
    {
        do
        {
            yield return new WaitForSeconds(arrowLeftTempo[arrowLeftCounter]);
            Instantiate(Arrows[3], Arrows[3].transform.position, Arrows[3].transform.rotation);
            arrowLeftCounter++;

        }
        while (arrowLeftCounter < arrowLeftTempo.Length);
    }
    IEnumerator ArrowSpawnerRight()
    {
        do
        {
            yield return new WaitForSeconds(arrowRightTempo[arrowRightCounter]);
            Instantiate(Arrows[2], Arrows[2].transform.position, Arrows[2].transform.rotation);
            arrowRightCounter++;

        }
        while (arrowRightCounter < arrowRightTempo.Length);
    }

}
