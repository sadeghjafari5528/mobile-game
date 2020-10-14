using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class camera : MonoBehaviour
{
    GameManager _GameManager;
    [Inject]
    public void Initializ(GameManager gamemanager)
    {
        _GameManager = gamemanager;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int _gamespeed = _GameManager._gamespeed;
        transform.Translate(Vector3.right * Time.deltaTime * _gamespeed);
    }
}
