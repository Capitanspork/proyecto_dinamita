using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibleCharacter : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(CharacterManager.Instance.personajeSeleccionado == 1)
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(1).gameObject.SetActive(false);

        }
        else {
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
