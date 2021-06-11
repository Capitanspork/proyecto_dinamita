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
        currentScore += scorePerNote * currentMultiplier;
        scoreTEXT.text = "Score; " + currentScore;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        currentMultiplier = 1;
        multiplierTRACKER = 0;

        MultiTEXT.text = "Multiplier: x" + currentMultiplier;

    }

}
