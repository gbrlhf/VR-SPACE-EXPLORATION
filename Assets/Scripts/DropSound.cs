using UnityEngine;

public class DropSound : MonoBehaviour
{
    public AudioSource dropAudio;
    public string groundTag = "Ground";
    public float minVelocity = 0.3f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("KENA: " + collision.gameObject.name + " | Tag: " + collision.gameObject.tag + " | Velocity: " + collision.relativeVelocity.magnitude);

        if (collision.gameObject.CompareTag(groundTag))
        {
            if (collision.relativeVelocity.magnitude > minVelocity)
            {
                if (dropAudio != null && dropAudio.clip != null)
                {
                    dropAudio.PlayOneShot(dropAudio.clip);
                    Debug.Log("SUARA MAIN!");
                }
            }
        }
    }
}