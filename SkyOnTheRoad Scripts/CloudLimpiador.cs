using UnityEngine;

public class CloudLimpiador : MonoBehaviour
{
    private Transform camTransform;
    [Tooltip("Distancia por debajo de la cámara para destruir la nube")]
    public float distanciaDestruccion = 15f; 

    void Start()
    {
        camTransform = Camera.main.transform;
    }

    void Update()
    {
        // Única responsabilidad: Destruirse si queda muy abajo de la cámara
        if (camTransform.position.y - transform.position.y > distanciaDestruccion)
        {
            Destroy(gameObject);
        }
    }
}