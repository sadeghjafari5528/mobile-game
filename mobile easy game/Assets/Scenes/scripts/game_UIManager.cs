using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

public class game_UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text _scoretext;
    [SerializeField]
    private GameObject _victorymenu;
    [SerializeField]
    private GameObject _defeatmenu;
    [SerializeField]
    private GameObject[] apples;
    [SerializeField]
    private GameObject bird;
    [SerializeField]
    private GameObject _resume_menu;
    private GameManager _GameManager;

    [Inject]
    public void Initialize(GameManager gamemanager)
    {
        _GameManager = gamemanager;
    }
    public void scoretext(int score)
    {
        _scoretext.text = "Score : " + score;
    }
    public void victoryUI(bool IsVictory)
    {
        if (IsVictory)
        {
            _victorymenu.SetActive(true);
        }
        else
        {
            _victorymenu.SetActive(false);
        }
    }
    public void enable_defeatUI()
    {
        _defeatmenu.SetActive(true);
    }
    public void play_again_button()
    {
        _victorymenu.SetActive(false);
        _defeatmenu.SetActive(false);
        _GameManager._gamescore = 0;
        scoretext(_GameManager._gamescore);

        bird.SetActive(true);
        bird.transform.position = new Vector3(-1017f, 436f, 0.4f);

        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.transform.position = new Vector3(-574f, 331, 0);

        //var apples = GameObject.FindGameObjectsWithTag("apple");
        //var apples = GameObject.FindWithTag("apple");
        foreach (GameObject apple in apples)
        {
            apple.SetActive(true);
        }

        _GameManager.Pause(false);
    }
    public void pause_button()
    {
        _GameManager.Pause(true);
        _resume_menu.SetActive(true);
    }
    public void resume_button()
    {
        _GameManager.Pause(false);
        _resume_menu.SetActive(false);
    }
    public void main_menu_button()
    {
        SceneManager.LoadScene("menu");
    }
}