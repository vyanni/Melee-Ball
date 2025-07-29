using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatisticsMenu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Statisticsmenu;
    public Text escore;
    public Text rescore;
    public Text bescore;
    public Text tscore;
    int totalscore;

    public void BackButton()
    {
        Mainmenu.SetActive(true);
        Statisticsmenu.SetActive(false);
    }

    void Update()
    {
        int totalscore = ScoreScript.enemyscoreValue + ScoreScript.rangedscoreValue + ScoreScript.bigEscorevalue;

        tscore.text = "Total Score: " + totalscore;
        escore.text = "Enemies Killed: " + ScoreScript.enemyscoreValue;
        rescore.text = "Ranged Enemies Killed: " + ScoreScript.rangedscoreValue;
        bescore.text = "Big Enemies Killed: " + ScoreScript.bigEscorevalue;
    }
}
