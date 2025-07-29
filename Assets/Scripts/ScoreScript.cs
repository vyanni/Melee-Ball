using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int enemyscoreValue = 0;
    public static int rangedscoreValue = 0;
    public static int bigEscorevalue = 0;
    public static int scoreValue = 0;   
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Score:  " + scoreValue;
        
        if (PlayerMovement.isDead)
        {
            score.color = new Color(1f, 1f, 1f, 1f);
        }
    }

}
