using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Panel Deskripsi")]
    public GameObject descriptionPanel;

    [Header("Object Spawn")]
    public GameObject gravityCube;

    // Simpan posisi & rotasi awal cube
    private Vector3 spawnPosition;
    private Quaternion spawnRotation;

    void Start()
    {
        if (descriptionPanel != null)
            descriptionPanel.SetActive(false);

        if (gravityCube != null)
        {
            // Catat posisi awal cube saat scene mulai
            spawnPosition = gravityCube.transform.position;
            spawnRotation = gravityCube.transform.rotation;

            gravityCube.SetActive(false);
        }
    }

    public void ToggleDescription()
    {
        if (descriptionPanel != null)
            descriptionPanel.SetActive(!descriptionPanel.activeSelf);
    }

    public void SpawnCube()
    {
        if (gravityCube != null)
        {
            // Reset posisi & rotasi cube ke posisi awal
            gravityCube.transform.position = spawnPosition;
            gravityCube.transform.rotation = spawnRotation;

            // Aktifkan cube
            gravityCube.SetActive(true);

            // Reset velocity dan angular velocity
            Rigidbody rb = gravityCube.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }

    public void HideCube()
    {
        if (gravityCube != null)
            gravityCube.SetActive(false);
    }
}