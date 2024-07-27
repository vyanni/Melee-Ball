using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Settingsmenu;
    public GameObject GraphicsButton;
    public GameObject PerformanceButton;

    public Text On1;
    public Text On2;
    public Text Off1;
    public Text Off2;

    public static bool PostProcessOn = false;

    public void BackButton()
    {
        Mainmenu.SetActive(true);
        Settingsmenu.SetActive(false);
    }

    public void PostProcessingOptionOn()
    {
        PostProcessOn = true;
        On1.color = new Color(1f, 1f, 1f, 1f);
        On2.color = new Color(1f, 1f, 1f, 0f);
        Off1.color = new Color(1f, 1f, 1f, 1f);
        Off2.color = new Color(1f, 1f, 1f, 0f);
    }

    public void PostProcessingOptionOff()
    {
        PostProcessOn = false;
        On1.color = new Color(1f, 1f, 1f, 0f);
        On2.color = new Color(1f, 1f, 1f, 1f);
        Off1.color = new Color(1f, 1f, 1f, 0f);
        Off2.color = new Color(1f, 1f, 1f, 1f);
    }
}
