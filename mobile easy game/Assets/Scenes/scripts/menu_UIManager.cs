using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_UIManager : MonoBehaviour
{
    public void play_button()
    {
        SceneManager.LoadScene("game");
    }
    public void setting_button()
    {
        SceneManager.LoadScene("setting");
    }
}
