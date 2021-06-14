using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaKiller : MonoBehaviour
{
    public GameObject MissEffect;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Offset")
        {
            GameManager.instance.NoteMissed();
            Instantiate(MissEffect, transform.position, MissEffect.transform.rotation);
        }
        
    }
}
