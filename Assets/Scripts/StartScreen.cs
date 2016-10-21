using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {
    public void StartGame()
    {
        GameManger.Instance.StartGame();
    }
}
