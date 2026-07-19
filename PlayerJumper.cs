using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    [Header("Componentes")]
    public Rigidbody rb;
    public Camera cam;
    private CapsuleCollider playerCollider;

    [Header("Movimiento Lateral")]
    public float Movimientox = 25f;
    private float minX, maxX;
    public float margin = 0.5f;

    [Header("Salto y Gravedad")]
    public float Salto = 10f;
    public float gravedadBase = -20f;         
    public float multiplicadorCaida = 4f;     

    [Header("Detección de Plataformas (Raycast)")]
    [Tooltip("Distancia desde el centro del jugador hacia abajo para detectar la plataforma")]
    public float distanciaRayo = 1.1f;
    [Tooltip("Capa (Layer) donde están las plataformas")]
    public LayerMask capaPlataformas;

    [Header("Efecto de Salto")]
    public GameObject saltoParticleEffectGameObject;  
    public ParticleSystem saltoParticleEffect;
    [Header("Sonido de Salto")]
    public AudioSource audioSource; // Referencia al componente AudioSource para reproducir el sonido de salto
    public AudioClip jumpSound; // Referencia al clip de sonido que se reproducirá al
    
    public Animator playerAnimator; // Referencia al Animator del jugador

    void Start()
    {
        float distance = transform.position.z - Camera.main.transform.position.z;
        minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + margin;
        maxX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance)).x - margin;

        cam = Camera.main;
        Input.gyro.enabled = true;

        rb = GetComponent<Rigidbody>();
        playerCollider = GetComponent<CapsuleCollider>();
        
        rb.freezeRotation = true;
        rb.useGravity = false; 

        // Forzamos a que el Rigidbody nunca se "duerma"
        rb.sleepThreshold = 0.0f;
    }

    void FixedUpdate()
    {
        // --- 1. MOVIMIENTO LATERAL ---
        float inclinacionX = Input.gyro.gravity.x;
        rb.linearVelocity = new Vector3(inclinacionX * Movimientox, rb.linearVelocity.y, rb.linearVelocity.z);

        // --- 2. GRAVEDAD PERSONALIZADA ---
        float gravedadAAplicar = gravedadBase;
        if (rb.linearVelocity.y < 0.1f) 
        {
            gravedadAAplicar *= multiplicadorCaida; 
        }
        rb.AddForce(Vector3.up * gravedadAAplicar, ForceMode.Acceleration);

        // --- 3. DETECCIÓN ACTIVA DE PLATAFORMAS ---
        ConfigurarDetecciónAbajo();
    }

    void LateUpdate()
    {
        float xLimitado = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(xLimitado, transform.position.y, transform.position.z);
    }

    private void ConfigurarDetecciónAbajo()
    {
        // Lanzamos el rayo desde el centro del jugador hacia abajo
        RaycastHit hit;
        Vector3 origenRayo = transform.position;

        // Dibujamos el rayo en el editor para que puedas calibrar la distancia visualmente
        Debug.DrawRay(origenRayo, Vector3.down * distanciaRayo, Color.red);

        // Si el rayo impacta algo en la capa de las plataformas...
        if (Physics.Raycast(origenRayo, Vector3.down, out hit, distanciaRayo, capaPlataformas))
        {
            OneWayPlatform plataforma = hit.collider.GetComponent<OneWayPlatform>();

            if (plataforma != null)
            {
                // Si es el piso inicial, salta siempre
                if (plataforma.esPisoInicial)
                {
                    EjecutarSalto();
                    playerAnimator.SetTrigger("OnGrounded2"); // Activamos la animación de salto
                    return;
                }

                // Para plataformas normales: Solo salta si ya empezó a caer (evita saltar mientras sube)
                if (rb.linearVelocity.y <= 0.1f)
                {
                    Debug.Log($"Raycast detectó plataforma: {hit.collider.name}. ¡Saltando!");
                    EjecutarSalto();
                    playerAnimator.SetTrigger("OnGrounded2"); // Activamos la animación de salto
                }
            }
        }
    }

    private void EjecutarSalto()
    {
        audioSource.PlayOneShot(jumpSound); // Reproducimos el sonido de salto
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        rb.AddForce(Vector3.up * Salto, ForceMode.Impulse);
        if (saltoParticleEffectGameObject != null)
        {
            GameObject effectInstance = Instantiate(saltoParticleEffectGameObject, transform.position, Quaternion.identity);
            ParticleSystem particle = effectInstance.GetComponentInChildren<ParticleSystem>();
            if (particle != null)
            {
                ParticleSystem.MainModule main = particle.main;
                float lifetime = main.duration + main.startLifetime.constantMax;
                Destroy(effectInstance, lifetime);
            }
            else
            {
                Destroy(effectInstance, 2f);
            }
        }
    }
}