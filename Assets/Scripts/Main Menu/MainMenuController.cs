using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    // === Dipanggil dari tombol Start ===
    public void StartGame()
    {
        Debug.Log("StartGame dipanggil!");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
    }

    // === Dipanggil dari tombol Exit ===
    public void ExitGame()
    {
        Debug.Log("Exit Game");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}