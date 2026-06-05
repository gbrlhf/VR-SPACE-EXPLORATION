using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun;              // matahari sebagai pusat orbit
    public float orbitSpeed = 10f;     // kecepatan mengelilingi matahari
    public float rotationSpeed = 30f;  // kecepatan rotasi poros sendiri

    void Update()
    {
        // Revolusi: orbit mengelilingi matahari (pakai sumbu dunia Y)
        if (sun != null)
        {
            transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }

        // Rotasi poros sendiri: pakai sumbu DUNIA (Space.World), bukan lokal
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }
}