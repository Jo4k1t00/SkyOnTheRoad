using UnityEngine;

public class MenuCloudMover : MonoBehaviour
{
    [Tooltip("Velocidad a la que la nube caerá para simular que subimos")]
    public float velocidadCaida = 3f;

    // Esta variable nos dirá si estamos en el menú o en el juego real
    private bool estamosEnMenu = false;

    void Start()
    {
        // Una forma sencilla de saber si estamos en el menú es verificar 
        // si no hay jugador en la escena.
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            estamosEnMenu = true;
        }
    }

    void Update()
    {
        if (estamosEnMenu)
        {
            // Movemos la nube hacia abajo. Esto le hace creer al jugador que la cámara sube.
            transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime);
        }
    }
}