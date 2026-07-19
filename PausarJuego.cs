using UnityEngine;

public class PausarJuego : MonoBehaviour
{
    public GameObject panelPausa; // Referencia al panel de pausa
    public bool juegoPausado = false; // Estado del juego
    public AudioSource audioSource; // Referencia al componente AudioSource para reproducir el sonido de clic
    public AudioClip pauseSound; // Referencia al clip de sonido que se reproducirá al hacer clic en un botón

    public AudioClip continueSound; // Referencia al clip de sonido que se reproducirá al hacer clic en un botón

    public void Reanudar()
    {
        audioSource.PlayOneShot(continueSound); // Reproducimos el sonido de clic al reanudar el juego
        panelPausa.SetActive(false); // Oculta el panel de pausa
        Time.timeScale = 1f; // Reanuda el tiempo del juego
        juegoPausado = false; // Cambia el estado del juego a no pausado
    }
    public void Pausar()
    {
        audioSource.PlayOneShot(pauseSound); // Reproducimos el sonido de clic al pausar el juego
        panelPausa.SetActive(true); // Muestra el panel de pausa
        Time.timeScale = 0f; // Pausa el tiempo del juego
        juegoPausado = true; // Cambia el estado del juego a pausado
    }
}
