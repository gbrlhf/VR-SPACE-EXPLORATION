using System.Collections;
using UnityEngine;

public class TeleportToSpace : MonoBehaviour
{
    public void LoadSpace()
    {
        StartCoroutine(LoadSpaceDelayed());
    }

    private IEnumerator LoadSpaceDelayed()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Space");
    }
}