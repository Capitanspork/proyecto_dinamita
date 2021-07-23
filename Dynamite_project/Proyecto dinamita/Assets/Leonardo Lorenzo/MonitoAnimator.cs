using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitoAnimator : MonoBehaviour
{
    public GameObject[] baileAnimSprites;
    public GameObject mainMonito;
    private bool animated,beingAnimated;
    

    // Update is called once per frame
    void Update()
    {
        monitoUp();
        monitoRight();
        monitoLeft();
        monitoDown();
        if (animated == false)
        {
            mainMonito.gameObject.SetActive(true);
        }
    }

    public void monitoLeft()
    {
        if (Input.GetKey(KeyCode.Q) && beingAnimated == false)
        {
            animated = true;
            beingAnimated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[0].gameObject.SetActive(true);
           
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animated = false;
            beingAnimated = false;
            baileAnimSprites[0].gameObject.SetActive(false);
        } 
    }

    public void monitoRight()
    {
        if (Input.GetKey(KeyCode.P) && beingAnimated == false)
        {
            animated = true;
            beingAnimated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[1].gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            animated = false;
            beingAnimated = false;
            baileAnimSprites[1].gameObject.SetActive(false);
        }  
    }

    public void monitoUp()
    {
        if (Input.GetKey(KeyCode.W) && beingAnimated == false)
        {
            animated = true;
            beingAnimated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[2].gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animated = false;
            beingAnimated = false;
            baileAnimSprites[2].gameObject.SetActive(false);
        }      
    }

    public void monitoDown()
    {
        if (Input.GetKey(KeyCode.O) && beingAnimated == false)
        {
            animated = true;
            beingAnimated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[3].gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            animated = false;
            beingAnimated = false;
            baileAnimSprites[3].gameObject.SetActive(false);
        } 
    }
}
