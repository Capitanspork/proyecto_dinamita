using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public Animator Izquierda;

    public KeyCode KeyToPress;

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            theSR.sprite = pressedImage;
            if(this.tag == "izquierda")
            {
                Izquierda.Play("NoteHIT");
            }
            
        }

        if (Input.GetKeyUp(KeyToPress))
        {
            theSR.sprite = defaultImage;
                
        }
    }
}
