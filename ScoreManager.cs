using UnityEngine;
using TMPro; // Esencial para controlar textos de TextMeshPro

public class ScoreManager : MonoBehaviour
{
    [Header("Referencias")]
    public Transform playerTransform;
    public TextMeshProUGUI textoPuntuacion; // Arrastra el componente de tu Canvas UI

    private float alturaMaxima = 0f;
    private float alturaInicial = 0f;

    void Start()
    {
        if (playerTransform == null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }

        // Guardamos la posición inicial para que el contador empiece en cero metros/puntos
        if (playerTransform != null)
        {
            alturaInicial = playerTransform.position.y;
            alturaMaxima = alturaInicial;
        }
    }

    void Update()
    {
        if (playerTransform == null) return;

        // Comprobamos si el jugador superó su altura récord actual
        if (playerTransform.position.y > alturaMaxima)
        {
            alturaMaxima = playerTransform.position.y;
        }

        // Calculamos la distancia neta recorrida
        float distanciaRecorrida = alturaMaxima - alturaInicial;

        // Convertimos a entero para no mostrar decimales molestos en pantalla
        int puntos = Mathf.FloorToInt(distanciaRecorrida);

        // Actualizamos el Canvas
        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = puntos.ToString() + " m";
        }
    }
}