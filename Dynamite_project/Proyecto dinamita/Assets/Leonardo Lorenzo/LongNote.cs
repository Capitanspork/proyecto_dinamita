using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongNote : MonoBehaviour
{
    public GameObject longNote;
    private Vector3 scaleChange;
    public int length;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(0, length, 0);
        longNote.transform.localScale += scaleChange;
        ///solo se pueden usar multiplos de dos para length.
        longNote.transform.position = new Vector3(transform.localPosition.x, transform.localPosition.y + length/2, transform.localPosition.z);
    }

}
