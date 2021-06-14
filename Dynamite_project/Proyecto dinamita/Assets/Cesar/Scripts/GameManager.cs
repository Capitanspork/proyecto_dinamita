using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic, hitNote, missNote;

    public bool startPlaying; 

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGOODnote = 125;
    public int scorePerPERFECTnote = 150;


    public int currentMultiplier;
    public int multiplierTRACKER;
    public int[] multiplierThresholds;


    public Text scoreTEXT;
    public Text MultiTEXT;

    void Start()
    {
        instance = this;

        scoreTEXT.text = "Score; 0";
        currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
    }
    public void NoteHit()
    {
        Debug.Log("Hit On Time");
        hitNote.Play();
        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTRACKER++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTRACKER)
            {
                multiplierTRACKER = 0;
                currentMultiplier++;
            } 
        }
        MultiTEXT.text = "Multiplier: x" + currentMultiplier;

        /*currentScore += scorePerNote * currentMultiplier;*/
        scoreTEXT.text = "Score; " + currentScore;
    }
    public void NormalHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
    }

    public void GoodHit()
    {
        currentScore += scorePerGOODnote * currentMultiplier;
        NoteHit();
    }

    public void PerfectHit()
    {
        currentScore += scorePerPERFECTnote * currentMultiplier;
        NoteHit();
    }


    public void NoteMissed()
    {
        Debug.Log("Missed Note");
        missNote.Play();
        currentMultiplier = 1;
        multiplierTRACKER = 0;

        MultiTEXT.text = "Multiplier: x" + currentMultiplier;

    }

}
