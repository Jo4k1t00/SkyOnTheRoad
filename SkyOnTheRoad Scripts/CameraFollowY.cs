using UnityEngine;

public class CameraFollowY : MonoBehaviour
{
    [Header("Referencias")]
    public Transform objetivoJugador;

    [Header("Configuración")]
    [Tooltip("Distancia vertical (Y) que mantendrá la cámara respecto al jugador al iniciar")]
    public float desfaseY = 3f;
    [Tooltip("Suavizado de la cámara. Valores más altos definen un seguimiento más rápido")]
    public float suavizado = 5f;

    private float alturaMaximaAlcanzada;
    private float posicionZInicial;
    private float posicionXInicial;

    void Start()
    {
        if (objetivoJugador == null)
        {
            objetivoJugador = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (objetivoJugador != null)
        {
            // Inicializamos la altura máxima basándonos en la posición inicial del jugador
            alturaMaximaAlcanzada = objetivoJugador.position.y + desfaseY;
        }

        // Guardamos las posiciones X y Z originales para que la cámara no se mueva hacia los lados
        posicionXInicial = transform.position.x;
        posicionZInicial = transform.position.z;
    }

    void LateUpdate()
    {
        if (objetivoJugador == null) return;

        // Calculamos cuál sería la posición ideal de la cámara en este frame
        float posicionYDeseada = objetivoJugador.position.y + desfaseY;

        // CONDICIÓN CLAVE: Si el jugador sube más allá del récord actual, actualizamos la altura máxima
        if (posicionYDeseada > alturaMaximaAlcanzada)
        {
            alturaMaximaAlcanzada = posicionYDeseada;
        }

        // La posición destino de la cámara SIEMPRE usará la altura máxima alcanzada (nunca baja)
        Vector3 posicionDestino = new Vector3(posicionXInicial, alturaMaximaAlcanzada, posicionZInicial);

        // Movemos la cámara de forma fluida hacia el destino utilizando interpolación lineal (Lerp)
        transform.position = Vector3.Lerp(transform.position, posicionDestino, suavizado * Time.deltaTime);
    }
}