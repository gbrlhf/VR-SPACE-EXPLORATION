using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gravitasi : MonoBehaviour
{
    [Header("Gravitasi Planet")]
    public float gravityValue = 9.81f;

    [Header("Status Grab")]
    private bool isGrabbed = false;

    private Rigidbody rb;
    private XRGrabInteractable grabInteractable;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrab);
            grabInteractable.selectExited.AddListener(OnRelease);
        }
    }

    void FixedUpdate()
    {
        if (!isGrabbed && rb != null)
        {
            rb.AddForce(Vector3.down * gravityValue, ForceMode.Acceleration);
        }
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        isGrabbed = true;
        rb.useGravity = false;
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        isGrabbed = false;
        rb.useGravity = false;
    }
}