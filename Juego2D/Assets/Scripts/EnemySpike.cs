using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Hit");

            // Intentamos obtener el componente PlayerRespawn
            PlayerRespawn playerRespawn = collision.transform.GetComponent<PlayerRespawn>();
            if (playerRespawn != null)
            {
                playerRespawn.PlayerDamaged();
            }
            else
            {
                Debug.LogWarning("El componente PlayerRespawn no se encontró en el objeto Player.");
            }
        }
    }
}
