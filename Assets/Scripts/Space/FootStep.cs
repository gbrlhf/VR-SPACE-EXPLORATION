using UnityEngine;
using UnityEngine.InputSystem;

public class FootstepSound : MonoBehaviour
{
    public AudioSource footstepAudio;
    public InputActionReference moveAction;  // referensi action Move
    public float threshold = 0.1f;            // batas minimum gerakan

    void Update()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        bool isMoving = input.magnitude > threshold;

        if (isMoving && !footstepAudio.isPlaying)
        {
            footstepAudio.Play();
        }
        else if (!isMoving && footstepAudio.isPlaying)
        {
            footstepAudio.Stop();
        }
    }
}