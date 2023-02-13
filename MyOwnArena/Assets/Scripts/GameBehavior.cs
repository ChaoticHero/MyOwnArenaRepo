using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    // 1
    public string labelText = "Collect all 20 items and win your freedom!";


    public int maxItems = 20;

    public string Text = "Lolipop will make you small making you hard to hit and the icecream will make you bigger making you get around quicker but easier to hit";

    private int _itemsCollected = 0;

    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;

            if (_itemsCollected >= maxItems)
            {
                labelText = "You've found all the items!";

                // 2
                showWinScreen = true;

                Time.timeScale = 0f;
            }
            else
            {
                labelText = "Item found, only " + (maxItems -
                   _itemsCollected) + " more to go!";
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
        }
    }

    // 3
    public bool showWinScreen = false;
    void OnGUI()
    {
        {
            // 4
            GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" +
                _playerHP);

            // 5
            GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " +
               _itemsCollected);

            // 6
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height -
               60, 400, 60), labelText);

            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height -
               40, 500, 80), Text);
           
        }
        // ... No changes to GUI layout needed ...

        // 3
        if (showWinScreen)
        {
            // 4
            if (GUI.Button(new Rect(Screen.width / 2 - 100,
               Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                // 3
                SceneManager.LoadScene(0);

                // 4
                Time.timeScale = 1.0f;
            }
        }
    }
}
