using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitoAnimator : MonoBehaviour
{
    public GameObject[] baileAnimSprites;
    public GameObject mainMonito;
    private bool animated;
    

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
        if (Input.GetKey(KeyCode.Q))
        {
            animated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[0].gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animated = false;
            baileAnimSprites[0].gameObject.SetActive(false);
        } 
    }

    public void monitoRight()
    {
        if (Input.GetKey(KeyCode.P))
        {
            animated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[1].gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            animated = false;
            baileAnimSprites[1].gameObject.SetActive(false);
        }  
    }

    public void monitoUp()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[2].gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animated = false;
            baileAnimSprites[2].gameObject.SetActive(false);
        }      
    }

    public void monitoDown()
    {
        if (Input.GetKey(KeyCode.O))
        {
            animated = true;
            mainMonito.gameObject.SetActive(false);
            baileAnimSprites[3].gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            animated = false;
            baileAnimSprites[3].gameObject.SetActive(false);
        } 
    }
}
