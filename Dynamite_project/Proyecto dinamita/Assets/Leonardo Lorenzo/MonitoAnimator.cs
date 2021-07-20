using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitoAnimator : MonoBehaviour
{
    public GameObject[] baileAnimSprites;
    

    // Update is called once per frame
    void Update()
    {
        monitoUp();
        monitoRight();
        monitoLeft();
        monitoDown();
    }

    public void monitoLeft()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            baileAnimSprites[0].gameObject.SetActive(true);
        }
        else
            baileAnimSprites[0].gameObject.SetActive(false);

    }

    public void monitoRight()
    {
        if (Input.GetKey(KeyCode.P))
        {
            baileAnimSprites[1].gameObject.SetActive(true);
        }
        else
            baileAnimSprites[1].gameObject.SetActive(false);

    }

    public void monitoUp()
    {
        if (Input.GetKey(KeyCode.W))
        {
            baileAnimSprites[2].gameObject.SetActive(true);
        }
        else
            baileAnimSprites[2].gameObject.SetActive(false);

    }

    public void monitoDown()
    {
        if (Input.GetKey(KeyCode.O))
        {
            baileAnimSprites[3].gameObject.SetActive(true);
        }
        else
            baileAnimSprites[3].gameObject.SetActive(false);

    }

}
