using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject SettingsMenu;
    public GameObject CustomizationMenu;
    public GameObject StatisticsMenu;

    public Transform Player;
    public Rigidbody2D rb;


    void Start()
    {
        Player.position = new Vector3(99, 99, 99);
    }

    void Update()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    public void SettingsOption()
    {
        Mainmenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void Customizing()
    {
        Mainmenu.SetActive(false);
        CustomizationMenu.SetActive(true);
        Player.position = new Vector3(-0.07f, 1.34f, 0f);
    }

    public void StatisticsOption()
    {
        Mainmenu.SetActive(false);
        StatisticsMenu.SetActive(true);
    }
}
