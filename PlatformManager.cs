using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [Header("Prefabs y Referencias")]
    public GameObject platformPrefab; 
    public Transform playerTransform; 
    public GameObject coinPrefab; // Prefab de la moneda

    [Header("Configuración de Generación")]
    public float distanciaGeneracion = 15f; 
    public float espacioMinY = 1.5f;       
    public float espacioMaxY = 3.5f;       
    
    [Header("Límites Horizontales")]
    public float minX = -5f;               
    public float maxX = 5f;                

    [Header("Curva de Dificultad (Tamaño de Plataforma)")]
    [Tooltip("Tamaño inicial de la plataforma (X) al empezar")]
    public float escalaMaxX = 2.5f;
    [Tooltip("Tamaño mínimo al que puede encogerse la plataforma")]
    public float escalaMinX = 0.8f;
    [Tooltip("A qué altura (Y) el juego alcanzará la máxima dificultad (plataformas mínimas)")]
    public float alturaDificultadMaxima = 500f;

    private float ultimaYGenerada = 0f;    

    [Header("Configuración de Monedas")]
    public float coinOffsetY = 1.0f; // Ajusta este valor para darle más o menos altura a la moneda

    void Start()
    {
        if (playerTransform == null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }

        ultimaYGenerada = playerTransform.position.y;

        for (int i = 0; i < 10; i++)
        {
            SpawnPlatform();
        }
    }

    void Update()
    {
        if (playerTransform.position.y + distanciaGeneracion > ultimaYGenerada)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        float siguienteY = ultimaYGenerada + Random.Range(espacioMinY, espacioMaxY);
        float randomX = Random.Range(minX, maxX);
        Vector3 posicionSpawn = new Vector3(randomX, siguienteY, playerTransform.position.z);

        // --- CÁLCULO DE DIFICULTAD ---
        // 't' será un valor entre 0 y 1 dependiendo de qué tan alto hayamos llegado
        float t = Mathf.Clamp01(siguienteY / alturaDificultadMaxima);
        
        // Interpola el tamaño: a mayor altura, más cerca de escalaMinX
        float tamañoXActual = Mathf.Lerp(escalaMaxX, escalaMinX, t);

        // Instanciamos la plataforma respetando la rotación del prefab
        GameObject nuevaPlataforma = Instantiate(platformPrefab, posicionSpawn, platformPrefab.transform.rotation);
  
        bool coinActive = Random.value > 0.5f; // 50% de probabilidad
         if(coinActive)
        {
            // 1. Calculamos una nueva posición un poco más arriba
             Vector3 posicionMoneda = new Vector3(posicionSpawn.x, posicionSpawn.y + coinOffsetY, posicionSpawn.z);
    
             // 2. Instanciamos la moneda en la nueva posición
            GameObject moneda = Instantiate(coinPrefab, posicionMoneda, Quaternion.identity);
 
        }


        // Aplicamos la escala respetando la del prefab original
        Vector3 escalaOriginal = platformPrefab.transform.localScale;
        float escalaXNueva = escalaOriginal.x * (tamañoXActual / escalaMaxX);
        nuevaPlataforma.transform.localScale = new Vector3(escalaXNueva, escalaOriginal.y, escalaOriginal.z);

        ultimaYGenerada = siguienteY;
    }
}