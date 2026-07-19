using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound; // Referencia al clip de sonido que se reproducirá al recoger la moneda
    private void OnTriggerEnter(Collider other)
    {
        // Única responsabilidad: Detectar si el objeto que entró es el jugador
        if (other.CompareTag("Player"))
        {
            // Intentamos obtener el AudioSource del objeto que colisionó (el jugador)
            AudioSource playerAudio = other.GetComponent<AudioSource>();

            // Si el jugador tiene el componente, lo usamos
            if (playerAudio != null && coinSound != null)
            {
                playerAudio.PlayOneShot(coinSound);
            }   
            // 1. Sumamos la moneda al marcador
            GameManager._gameManager.AddCoins();

            // 2. Llamamos a la función que ya creaste para instanciar las partículas en esta posición
            GameManager._gameManager.PlayCoinParticle(transform.position);

            // 3. Destruimos la moneda de la escena
            Destroy(gameObject);
        }
    }
}