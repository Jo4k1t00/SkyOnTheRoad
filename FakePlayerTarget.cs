using UnityEngine;

public class FakePlayerTarget : MonoBehaviour
{
    [Tooltip("Debe ser exactamente la misma velocidad que el MenuCloudMover de las nubes")]
    public float velocidadSubida = 3f;

    void Update()
    {
        // Mueve este objeto hacia arriba de forma constante
        transform.Translate(Vector3.up * velocidadSubida * Time.deltaTime);
    }
}