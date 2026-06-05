using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource clickAudio;

    public void PlayClick()
    {
        if (clickAudio != null && clickAudio.clip != null)
        {
            clickAudio.PlayOneShot(clickAudio.clip);
        }
    }
}