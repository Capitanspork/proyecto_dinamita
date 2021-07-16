using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongNote : MonoBehaviour
{
    public GameObject longNote;
    private Vector3 scaleChange;
    public int length;

    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject HitEffect, goodEffect, perfectEffect;

    void Start()
    {
        scaleChange = new Vector3(0, length, 0);
        longNote.transform.localScale += scaleChange;
        ///solo se pueden usar multiplos de dos para length.
        longNote.transform.position = new Vector3(transform.localPosition.x, transform.localPosition.y + length / 2, transform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);

                switch (keyToPress)
                {
                    case KeyCode.Q:
                        GameManager.instance.LeftAnimation();
                        break;
                    case KeyCode.P:
                        GameManager.instance.RightAnimation();
                        break;
                    case KeyCode.O:
                        GameManager.instance.DownAnimation();
                        break;
                    case KeyCode.W:
                        GameManager.instance.UpAnimation();
                        break;
                }


                GameManager.instance.NoteHit();


                if (Mathf.Abs(transform.position.y) > 0.25)
                {
                    Debug.Log("Hit");
                    GameManager.instance.NormalHit();
                    //Instantiate(HitEffect, transform.position, HitEffect.transform.rotation);

                }
                else if (Mathf.Abs(transform.position.y) > 0.05f)
                {
                    Debug.Log("Good");
                    GameManager.instance.GoodHit();
                    //Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                }
                else
                {
                    Debug.Log("Perfect");
                    GameManager.instance.PerfectHit();
                    //Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
}
