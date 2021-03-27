using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{

    [SerializeField]
    GameObject GameUI;

    [SerializeField]
    GameObject PreviewCamera;

    [SerializeField]
    GameObject Player;

    public void Continue()
    {

    }

    public void StartGame()
    {
        PreviewCamera.SetActive(false);
        GameUI.SetActive(true);
        Player.SetActive(true);
        gameObject.SetActive(false);
    }

    public void EndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
