using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    public int _gamespeed = 300;
    public int _flyspeed = 800;
    public int _gravityspeed = 200;
    public int _gamescore = 0;

    public void Pause(bool pause)
    {
        if (pause)
        {
            _gamespeed = 0;
            _flyspeed = 0;
            _gravityspeed = 0;
        }
        else
        {
            _gamespeed = 300;
            _flyspeed = 800;
            _gravityspeed = 200;
        }
    }
}
