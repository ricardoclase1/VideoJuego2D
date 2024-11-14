using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    public GameObject Yong;

    private void Update()
    {
        Vector3 direction = Yong.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f); 
    }

    // Detecta colisiones
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el objeto colisionado tiene el tag "Player"
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Hit by Grunt");

            // Intentamos obtener el componente PlayerRespawn del jugador
            PlayerRespawn playerRespawn = collision.transform.GetComponent<PlayerRespawn>();
            if (playerRespawn != null)
            {
                playerRespawn.PlayerDamaged(); // Llama al método de daño del jugador
            }
            else
            {
                Debug.LogWarning("El componente PlayerRespawn no se encontró en el objeto Player.");
            }
        }
    }
}
