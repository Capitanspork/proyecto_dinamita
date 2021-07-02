using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iluminada : MonoBehaviour
{

    public AnimationClip hitEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Flecha")
        {
            AnimationClip effect = Instantiate(hitEffect, transform.position, transform.rotation);
            Debug.Log("penewaffle");
        }
            
    }



}
