using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class setting_UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _leveltext;
    private GameManager _GameManager;
    [Inject]
    public void initializate(GameManager gamemanager)
    {
        _GameManager = gamemanager;
    }
    public void hard_button()
    {
        //_GameManager._gamespeed = 450;
        PlayerPrefs.SetInt("GameSpeed", 450);
        _leveltext.text = "game level : " + "hard";
    }
    public void normal_button()
    {
        //_GameManager._gamespeed = 300;
        PlayerPrefs.SetInt("GameSpeed", 300);
        _leveltext.text = "game level : " + "normal";
    }
    public void easy_button()
    {
        //_GameManager._gamespeed = 200;
        PlayerPrefs.SetInt("GameSpeed", 200);
        _leveltext.text = "game level : " + "easy";
    }
    public void main_menu_button()
    {
        SceneManager.LoadScene("menu");
    }
}
