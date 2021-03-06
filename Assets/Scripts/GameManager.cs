using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer
{
    private float _seconds = 0;
    public float Seconds { get { return _seconds; } }
    private float _minutes = 0;
    public float Minutes { get { return _minutes; } }
    private float _hours = 0;
    public float Hours { get { return _hours; } }

    public void AddTime(float seconds, float minutes = 0, float hours = 0)
    {
        _seconds += seconds;
        _minutes += minutes;
        _hours += hours;
        if (_seconds >= 60)
        { _seconds -= 60; _minutes += 1; }
        if (_minutes >= 60)
        { _minutes -= 60; _hours += 1; }
    }

    public string PrintTime()
    {
        string seconds = _seconds < 10 ? "0" + ((int)_seconds).ToString() : ((int)_seconds).ToString();
        string minutes = _minutes < 10 ? "0" + ((int)_minutes).ToString() : ((int)_minutes).ToString();

        return _hours.ToString() + ":" + minutes + ":" + seconds;
    }
}

public class GameManager : Singleton<GameManager>
{
    public PlayerController player = null;
    public static int score = 0;
    public Timer timer;
    public TextMeshProUGUI timerUI;
    public TextMeshProUGUI scoreUI;
    public Canvas pauseMenu;
    public Canvas winMenu;
    private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = new Timer();
        pauseMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer.AddTime(Time.deltaTime);
        timerUI.text = "Time: " + timer.PrintTime();
        scoreUI.text = "Score: " + score;
    }

    //True to activate cursor and disable input, false to return
    public void SwitchToUI(bool activateUI)
    {
        player.paused = activateUI;
        Cursor.lockState = activateUI ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public void Pause()
    {
        paused = !paused;
        pauseMenu.enabled = paused;
        SwitchToUI(paused);
        Time.timeScale = paused ? 0 : 1;
    }

    public void GameWon()
    {
        Time.timeScale = 0;
        SwitchToUI(true);
        //timerUI.enabled = false;
        //scoreUI.enabled = false;
        winMenu.enabled = true;

    }

    public void ResetCrystals()
    {
       foreach (Crystal item in FindObjectsOfType<Crystal>())
        {
            item.EnableCollect();
        }
    }

    public void LoadLevel(string levelName)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelName);
    }
}
