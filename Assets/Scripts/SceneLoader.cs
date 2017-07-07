using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadSceneAsync("Menu 3D");
    }

    public void LoadSinglePlayerScene()
    {
        SceneManager.LoadSceneAsync("SinglePlayer");
    }

    public void LoadMultiplayerScene()
    {
        SceneManager.LoadSceneAsync("Multiplayer");
    }

    public void LoadCurrentScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
}