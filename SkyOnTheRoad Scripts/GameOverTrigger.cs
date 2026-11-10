using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    [Header("UI de Fracaso")]
    [Tooltip("Arrastra aquí tu Canvas de Game Over")]
    public GameObject canvasGameOver;
    public AudioClip GameOverSound; // Referencia al clip de sonido que se reproducirá al activar el Game Over

    public GameObject Dead;
    public GameObject PlayerModel;
    public GameObject PlayerCollider; // Referencia al jugador
    public AudioSource audioSource; // Referencia al AudioSource del jugador
    [Header("Audio de Ambiente")]
    [Tooltip("Arrastra aquí el AudioSource del objeto vacío que reproduce el ambiente")]
    public AudioSource ambientAudioSource;

    private void Start()
    {
        if (canvasGameOver != null)
        {
            canvasGameOver.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Única responsabilidad: Detectar la caída del jugador
        if (other.CompareTag("Player"))
        {
            Dead.SetActive(true);
            Debug.Log("¡El jugador pasó el límite inferior! Activando Game Over...");
            AudioSource playerAudio = other.GetComponent<AudioSource>();
            // Si el jugador tiene el componente, lo usamos
            if (playerAudio != null && GameOverSound != null)
            {
                playerAudio.PlayOneShot(GameOverSound);
            }
            ActivarGameOver();
        }
    }

    private void ActivarGameOver()
    {

        if (canvasGameOver != null)
        {
            canvasGameOver.SetActive(true);
        }

        if (ambientAudioSource != null)
        {
            ambientAudioSource.Stop();
        }

        PlayerModel.SetActive(false); // Desactivamos al jugador para que no pueda moverse

        if (PlayerCollider != null)
        {
            Collider[] colliders = PlayerCollider.GetComponents<Collider>();
            Rigidbody rb = PlayerCollider.GetComponent<Rigidbody>();
            foreach (Collider colliderToDisable in colliders)
            {
                rb.isKinematic = true; // Hacemos que el Rigidbody sea cinemático para que no responda a la física
                colliderToDisable.enabled = false;
            }
        }
        // Congelamos el juego
        Time.timeScale = 1f; 
    }
}