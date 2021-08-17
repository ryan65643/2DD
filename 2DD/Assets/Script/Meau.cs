using UnityEngine;
using UnityEngine.SceneManagement;

public class Meau : MonoBehaviour
{
    public GameObject StartGame;

    private void Awake()
    {
        StartGame = GameObject.Find("Canvas");
    }

    public void Play()
    {
      StartGame.SetActive(false);
    }
    public void quit()
    {
        Application.Quit();
    }
}
