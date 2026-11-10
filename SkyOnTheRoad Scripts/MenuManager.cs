using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuManager : MonoBehaviour
{
    [Header("Configuración de Escenas")]
    [Tooltip("Escribe el nombre exacto de tu escena de juego (ej: Game, Nivel1, Juego)")]
    public string nombreEscenaJuego = "Juego";

    public AudioSource audioSource; // Referencia al componente AudioSource para reproducir el sonido de clic
    public AudioClip buttonClickSound; // Referencia al clip de sonido que se reproducirá al hacer clic en un botón
    /// <summary>
    /// Carga la escena del juego para empezar a jugar. (Para el botón JUGAR)
    /// </summary>
    public void IniciarJuego()
    {
        // IMPORTANTE: Nos aseguramos de que el tiempo esté en 1f por si venimos de una pausa
        Time.timeScale = 1f; 
        audioSource.PlayOneShot(buttonClickSound); // Reproducimos el sonido de clic al iniciar el juego
        // Cargamos la escena principal por su nombre
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Cargamos la siguiente escena en el índice de construcción
    }

    /// <summary>
    /// Recarga la escena actual desde cero. (Para el botón REINICIAR)
    /// </summary>
    public void ReiniciarJuego()
    {
        Time.timeScale = 1f; 
        audioSource.PlayOneShot(buttonClickSound); // Reproducimos el sonido de clic al reiniciar el juego
        SceneManager.LoadScene(nombreEscenaJuego); // Recargamos la escena principal por su nombre
    }

    /// <summary>
    /// Cierra la aplicación por completo. (Para el botón SALIR)
    /// </summary>
    public void SalirDelJuego()
    {
        audioSource.PlayOneShot(buttonClickSound); // Reproducimos el sonido de clic al salir del juego
        Debug.Log("Saliendo del juego... (Esto funciona en la build final)");
        
        // Cierra la aplicación (funciona en PC y móviles)
        Application.Quit();
    }
        public void SalirAlMenu()
    {
        audioSource.PlayOneShot(buttonClickSound); // Reproducimos el sonido de clic al salir al menú
        Debug.Log("Saliendo al menú... (Esto funciona en la build final)");
        
        // Cierra la aplicación (funciona en PC y móviles)
        SceneManager.LoadScene("Menu");
    }
}