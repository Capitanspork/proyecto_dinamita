using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

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


    public TextMeshProUGUI scoreTEXT;
    public TextMeshProUGUI MultiTEXT;

    public float TotalNotes;
    public float NormalHits;
    public float GoodHits;
    public float PerfectHits;
    public float MissedHits;
    public float delay;

    public GameObject resultScreen;
    public TextMeshProUGUI PercentHitText, NormalsText, GoodsText, PerfectsText, MissesText, RankText, FinalScoreText;

    void Start()
    {
        instance = this;

        scoreTEXT.text = "Score: 0";
        currentMultiplier = 1;

        TotalNotes = FindObjectsOfType<NoteObject>().Length;

    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (!startPlaying)
        {
            if (delay <= 0)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }

        }
        else
        {
            if (!theMusic.isPlaying && !resultScreen.activeInHierarchy)
            {
                resultScreen.SetActive(true);

                NormalsText.text = "" + NormalHits;
                GoodsText.text = "" + GoodHits.ToString();
                PerfectsText.text = "" + PerfectHits.ToString();
                MissesText.text = "" + MissedHits;

                float totalHit = NormalHits + GoodHits + PerfectHits;
                float percenHit = (totalHit / TotalNotes) * 100f;

                PercentHitText.text = percenHit.ToString("F1") + "%";

                string rankVal = "F";

                if(percenHit > 40)
                {
                    rankVal = "D";
                    if(percenHit > 55)
                    {
                        rankVal = "C";
                        if(percenHit > 70)
                        {
                            rankVal = "B";
                            if(percenHit > 85)
                            {
                                rankVal = "A";
                                if(percenHit > 95)
                                {
                                    rankVal = "S";
                                    if(percenHit > 99)
                                    {
                                        rankVal = "S+";
                                    }
                                }
                            }
                        }
                    }
             
                }
                RankText.text = rankVal;

                FinalScoreText.text = currentScore.ToString();
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
        EffectSpawner.instance.spawnPrefab(0);

        NormalHits++;
    }

    public void GoodHit()
    {
        currentScore += scorePerGOODnote * currentMultiplier;
        NoteHit();
        EffectSpawner.instance.spawnPrefab(1);
        GoodHits++;
    }

    public void PerfectHit()
    {
        currentScore += scorePerPERFECTnote * currentMultiplier;
        NoteHit();
        EffectSpawner.instance.spawnPrefab(2);
        PerfectHits++;
    }


    public void NoteMissed()
    {
        Debug.Log("Missed Note");
        missNote.Play();
        currentMultiplier = 1;
        multiplierTRACKER = 0;
        EffectSpawner.instance.spawnPrefab(3);

        MissedHits++;
        MultiTEXT.text = "Multiplier: x" + currentMultiplier;

    }

}
