using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    public Button button;

    public void StartAGame()
    {
        SceneManager.LoadScene("Game");
    }
}
