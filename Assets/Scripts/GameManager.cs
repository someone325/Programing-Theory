using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text win_text;
    public Text lose_text;
    public Button reset_button;
    public Button level_button;
    public bool play;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        play = true;
        win_text.gameObject.SetActive(false);
        lose_text.gameObject.SetActive(false);
        reset_button.gameObject.SetActive(false);
        level_button.gameObject.SetActive(false);
    }

    public void End_Game(bool win)
    {
        play = false;
        if (win) win_text.gameObject.SetActive(true);
        else lose_text.gameObject.SetActive(true);
        reset_button.gameObject.SetActive(true);
        level_button.gameObject.SetActive(true);
    }
}
