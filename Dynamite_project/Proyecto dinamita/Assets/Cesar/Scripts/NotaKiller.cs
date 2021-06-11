using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaKiller : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Offset")
        {
            GameManager.instance.NoteMissed();
        }
        
    }
}
