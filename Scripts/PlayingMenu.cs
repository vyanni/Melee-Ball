using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingMenu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Playmenu;
    public GameObject MapMenu;

    public void BackButton()
    {
        Mainmenu.SetActive(true);
        Playmenu.SetActive(false);
    }

    public void Maps()
    {
        MapMenu.SetActive(true);
    }
}
