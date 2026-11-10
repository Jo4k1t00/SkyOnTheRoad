using UnityEngine;

public class CloudManager : MonoBehaviour
{
    [Header("Referencias")]
    [Tooltip("Arrastra aquí tus prefabs de nubes")]
    public GameObject[] cloudPrefabs; 
    [Tooltip("El objeto que las nubes deben seguir (El Jugador en el juego, o la Cámara en el menú)")]
    public Transform referenciaSeguimiento; 

    [Header("Configuración de Generación")]
    public int nubesIniciales = 8;
    public float distanciaGeneracion = 20f; 
    
    [Header("Posicionamiento")]
    public float minX = -8f;               
    public float maxX = 8f;                
    public float espacioMinY = 2f;       
    public float espacioMaxY = 5f; 
    [Tooltip("Qué tan atrás estarán las nubes. Debe ser mayor al Z de tus plataformas")]
    public float profundidadZ = 15f; 

    private float ultimaYGenerada = 0f;

    public float escala = 4;
    void Start()
    {
        // Si no asignaste referencia, buscamos la cámara principal por defecto
        if (referenciaSeguimiento == null)
        {
            referenciaSeguimiento = Camera.main.transform;
        }

        // Empezamos a generar un poco por debajo de la referencia inicial
        ultimaYGenerada = referenciaSeguimiento.position.y - 5f;

        // Generación de inicio
        for (int i = 0; i < nubesIniciales; i++)
        {
            SpawnCloud();
        }
    }

    void Update()
    {
        // Si la referencia (jugador o cámara simulada) sube, generamos más nubes
        if (referenciaSeguimiento.position.y + distanciaGeneracion > ultimaYGenerada)
        {
            SpawnCloud();
        }
    }

    void SpawnCloud()
    {
        float siguienteY = ultimaYGenerada + Random.Range(espacioMinY, espacioMaxY);
        float randomX = Random.Range(minX, maxX);
        Vector3 posicionSpawn = new Vector3(randomX, siguienteY, profundidadZ);

        // Elegir un prefab de nube al azar
        GameObject nubeElegida = cloudPrefabs[Random.Range(0, cloudPrefabs.Length)];
        GameObject nuevaNube = Instantiate(nubeElegida, posicionSpawn, Quaternion.identity);

        // --- TOQUE ESTÉTICO ---
        // Variamos un poco el tamaño y podemos voltearla horizontalmente para que no se vean repetidas
        float direccionX = Random.value > 0.5f ? 1f : -1f; // 50% de probabilidad de mirar al lado contrario
        nuevaNube.transform.localScale = new Vector3(escala * direccionX, escala, 1f);

        ultimaYGenerada = siguienteY;
    }
}