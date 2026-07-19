using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Única responsabilidad: Borrar plataformas que caen para optimizar rendimiento
        if (other.GetComponent<OneWayPlatform>() != null)
        {
            Destroy(other.gameObject);
        }
    }
}