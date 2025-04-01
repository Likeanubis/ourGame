using UnityEngine;
using UnityEngine.SceneManagement;
public class playGame : MonoBehaviour
{
    public string scene = "Game";
    

    public void loadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
