using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancearAnim : MonoBehaviour
{
    public Animator Izquierda;

    public NoteObject _funcion;


    void Update()
    {
        if (_funcion.canBePressed)
        {
            if (this.tag == "izquierda")
            {
                Izquierda.Play("NoteHIT");
                Debug.Log("AnimacionPENE");
            }
        }
    }
}
