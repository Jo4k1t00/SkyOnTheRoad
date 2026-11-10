using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _gameManager;
    public int coins;
    public GameObject CoinParticleSystemObject;
    public ParticleSystem CoinParticleSystem;

    void Awake()
    {
        // Configuración típica de Singleton para evitar duplicados entre escenas
        if (_gameManager == null)
        {
            _gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        CargarMonedas();
    }

    public void PlayCoinParticle(Vector3 position)
    {
        if (CoinParticleSystemObject != null)
        {
            GameObject effectCoin = Instantiate(CoinParticleSystemObject, position, Quaternion.identity);
            ParticleSystem particleCoin = effectCoin.GetComponentInChildren<ParticleSystem>();

            if (particleCoin != null)
            {
                particleCoin.Play();
                ParticleSystem.MainModule main = particleCoin.main;
                float lifetime = main.duration + main.startLifetime.constantMax;
                Destroy(effectCoin, lifetime);
            }
            else
            {
                Destroy(effectCoin, 2f);
            }
        }
        else if (CoinParticleSystem != null)
        {
            ParticleSystem particleCoin = Instantiate(CoinParticleSystem, position, Quaternion.identity);
            particleCoin.Play();
            ParticleSystem.MainModule main = particleCoin.main;
            float lifetime = main.duration + main.startLifetime.constantMax;
            Destroy(particleCoin.gameObject, lifetime);
        }
    }

    public void AddCoins()
    {
        coins++;
        GuardarMonedas();
    }

    // Restar monedas al comprar algo
    public bool GastarMonedas(int cantidad)
    {
        if (coins >= cantidad)
        {
            coins -= cantidad;
            GuardarMonedas();
            return true; // Compra exitosa
        }
        return false; // No alcanza el dinero
    }

    public void GuardarMonedas()
    {
        PlayerPrefs.SetInt("TotalMonedas", coins);
        PlayerPrefs.Save();
    }

    private void CargarMonedas()
    {
        // Si no existe la clave "TotalMonedas", por defecto empieza en 0
        coins = PlayerPrefs.GetInt("TotalMonedas", 0);
    }
}