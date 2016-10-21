using UnityEngine;

public class MainScreen : MonoBehaviour {

    public void GetIron()
    {
        GameManger.Instance.GetIron();
    }

    public void MakeSpaceShip()
    {
        GameManger.Instance.MakeSpaceShip();
    }
}
