using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomizationMenu : MonoBehaviour
{
    public GameObject character;
    public GameObject Mainmenu;
    public GameObject Customizationmenu;
    public Transform Player;

    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites To Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;


    public void BackButton()
    {
        Mainmenu.SetActive(true);
        Customizationmenu.SetActive(false);
        Player.position = new Vector3(99, 99, 99);
    }

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }

        bodyPart.sprite = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if(currentOption < 0)
        {
            currentOption = options.Count - 1;
        }

        bodyPart.sprite = options[currentOption];
    }

    public void Submit()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Objects/Player.prefab");
    }
}
