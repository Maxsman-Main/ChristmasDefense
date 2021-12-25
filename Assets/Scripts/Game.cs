using System;
using Characters;
using UnityEngine;
using UnityEngine.SceneManagement;

enum GameStatus
{
    Pause,
    Game
}

public class Game : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private StopGameUI _stopUI;

    private GameStatus _status;
    
    private void Start()
    {
        _player.OnDied += StopGame;
        Time.timeScale = 1;
        _status = GameStatus.Game;
    }

    private void StopGame()
    {
        Time.timeScale = 0;
        _stopUI.ShowUI();
        _status = GameStatus.Pause;
    }

    public void RestartGame()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    private void Update()
    {
        if (_status == GameStatus.Pause && Input.anyKey)
        {
            RestartGame();
        }
    }
}