using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class LvlCanvasScript : MonoBehaviour
{
    [SerializeField] private AudioSource clickSound;
    [SerializeField] private GameObject pauseWindow;
    [SerializeField] private GameObject winWindow;
    [SerializeField] private GameObject fallWindow;
    [SerializeField] private Text timer;
    [SerializeField] private Text timerEnd;
    public float startTime;
    public float currentTime;
    public bool timeOver;
    private void Awake()
    {
        currentTime = startTime;
        timeOver = false;
        PauseDisable();
        winWindow.SetActive(false);
        fallWindow.SetActive(false);
    }
    private void FixedUpdate()
    {
        Timer();
    }
    public void PauseActive()
    {
        pauseWindow.SetActive(true);
        Time.timeScale = 0;
    }
    public void PauseDisable()
    {
        pauseWindow.SetActive(false);
        Time.timeScale = 1;
    }
    public void ChooseLvl(int bildIndex)
    {
        SceneManager.LoadScene(bildIndex);
    }
    public void Click()
    {
        clickSound.Play();
    }
    private void Timer()
    {
        if (currentTime <= 0)
        {
            timeOver = true;
            timer.text = "0";
            Fall();
        }
        else
        {
            currentTime -= Time.fixedDeltaTime;
            timer.text = string.Format("{0:N2}", currentTime);
        }
    }
    public void Win()
    {
        winWindow.SetActive(true);
        Time.timeScale = 0;
        timerEnd.text = string.Format("{0:N2}", startTime - currentTime);
    }
    public void Fall()
    {
        fallWindow.SetActive(true);
        Time.timeScale = 0;
    }
}