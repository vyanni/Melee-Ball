using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelector : MonoBehaviour
{
    public GameObject MapMenu;
    public GameObject Map1Img;
    public GameObject Map2Img;
    public GameObject Map3Img;

    public GameObject Map1Play;
    public GameObject Map2Play;
    public GameObject Map3Play;

    public Rigidbody2D rb;

    public void OpenMenu()
    {
        MapMenu.SetActive(true);
    }

    public void CloseMenu()
    {
        MapMenu.SetActive(false);
    }

    public void Map1()
    {
        Map1Img.SetActive(true);
        MapMenu.SetActive(false);
        Map1Play.SetActive(true);
        Map2Play.SetActive(false);
        Map3Play.SetActive(false);
    }

    public void Map2()
    {
        Map2Img.SetActive(true);
        MapMenu.SetActive(false);
        Map2Play.SetActive(true);
        Map1Play.SetActive(false);
        Map3Play.SetActive(false);
    }

    public void Map3()
    {
        Map3Img.SetActive(true);
        MapMenu.SetActive(false);
        Map3Play.SetActive(true);
        Map1Play.SetActive(false);
        Map2Play.SetActive(false);
    }

    public void PlayMap1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void PlayMap2()
    {
        SceneManager.LoadScene("Map2");
    }

    public void PlayMap3()
    {
        SceneManager.LoadScene("Map3");
    }
}
