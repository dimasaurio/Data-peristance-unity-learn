using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private Text playerNameInput;

    //Starts the game.
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    //Retrieves player name from the ui text input, and sends it to DataManager.
    public void SetPlayerName()
    {
        DataManager.Instance.playerName = playerNameInput.text;
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
