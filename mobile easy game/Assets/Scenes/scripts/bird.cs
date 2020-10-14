using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class bird : MonoBehaviour
{
    private GameManager _GameManager;
    private game_UIManager _UIManager;
    [Inject]
    public void Initialize(GameManager gamemanager , game_UIManager uimanager)
    {
        _GameManager = gamemanager;
        _UIManager = uimanager;
    }
    // Start is called before the first frame update
    void Start()
    {
        _GameManager._gamespeed = PlayerPrefs.GetInt("GameSpeed");
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        out_of_map();

    }
    void movement()
    {
        int _gamespeed = _GameManager._gamespeed;
        int _flyspeed = _GameManager._flyspeed;
        int _gravityspeed = _GameManager._gravityspeed;
        // for move forward
        transform.position = new Vector3(transform.position.x + Time.deltaTime * _gamespeed, transform.position.y - Time.deltaTime * _gravityspeed, 0.39f);

        //for flying
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * _flyspeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "apple")
        {
            _GameManager._gamescore += 1;
            _UIManager.scoretext(_GameManager._gamescore);
            other.gameObject.SetActive(false);
            //Instantiate(_EnemyExplotionPrefabs, transform.position, Quaternion.identity);
            //_UImanager.UpdateScore();
            //AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position);
        }
        else if (other.tag == "egle" || other.tag == "cat")
        {
            _GameManager.Pause(true);
            _UIManager.enable_defeatUI();
            this.gameObject.SetActive(false);
        }else if(other.tag == "tree")
        {
            transform.position = new Vector3(1200f, 450f, 0.4f);
            _GameManager.Pause(true);
            _UIManager.victoryUI(true);
            //Debug.Log(_GameManager._victory);
        }
    }
    private void out_of_map()
    {
        if (transform.position.y < -100f || transform.position.y > 750)
        {
            _GameManager.Pause(true);
            _UIManager.enable_defeatUI();
            this.gameObject.SetActive(false);
        }
    }
}
