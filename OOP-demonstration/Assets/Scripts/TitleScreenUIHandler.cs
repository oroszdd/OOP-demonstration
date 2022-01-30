using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenUIHandler : MonoBehaviour
{
    public InputField ballsPerMinute;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SaveBallsPerMinuteInput()
    {
        DataManager.Instance.spawnRateModifier = float.Parse(ballsPerMinute.text);
    }
}
