using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    // 1
    public string labelText = "Collect all 20 items and win your freedom!";


    public int maxItems = 20;

    public string Text = "Lolipop will make you small making you hard to hit and the icecream will make you bigger making you get around quicker but easier to hit";

    private int _itemsCollected = 0;


    void losingscene()
    {
        SceneManager.LoadScene(3);
    }
    void winningscene()
    {
        SceneManager.LoadScene(2);
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;

            if (_itemsCollected >= maxItems)
            {
                

                // 2
                showWinScreen = true;

                Time.timeScale = 0f;
            }
            else
            {
                
            }
        }
    }
    private int _playerHP = 3;
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
            if (_playerHP <= 0)
            {
                
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                
            }
        }
    }

    // 3
    public bool showWinScreen = false;
    public bool showLossScreen = false;
    void OnGUI()
    {
       
          
        // ... No changes to GUI layout needed ...

        // 3
        if (showWinScreen)
        {
            winningscene();
        }
        if (showLossScreen)
        {
            losingscene();
        }
    }
}
