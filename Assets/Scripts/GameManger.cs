using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject MainScreen;
    public GameObject EndScreen;

    public int Iron;
    public int SpaceShip;

    private GameObject currentScreen;

    public static GameManger Instance;

    void Start()
    {
        Instance = this;
        Show(StartScreen);
    }

    public void StartGame()
    {
        Show(MainScreen);
    }

    public void EndGame()
    {
        Show(EndScreen);
    }

    public void GetIron()
    {

    }

    public void MakeSpaceShip()
    {

    }

    void Show(GameObject screen)
    {
        if (currentScreen != null)
        {
            Destroy(currentScreen);
        }
        currentScreen = (GameObject)Instantiate(screen, transform, false);
    }
}
